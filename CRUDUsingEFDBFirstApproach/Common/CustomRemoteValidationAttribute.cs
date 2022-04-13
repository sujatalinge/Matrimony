using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Reflection;

namespace CRUDUsingEFDBFirstApproach.Common
{
    public class CustomRemoteValidationAttribute
        :RemoteAttribute    
    {
        string controllerName = string.Empty;
        string actionName = string.Empty;
        public CustomRemoteValidationAttribute
            (string action,string controller)
            :base(action,controller)
        {
            controllerName = controller;
            actionName = action;

        }
        public override bool IsValid(object value)
        {
            //Reflection code
          Assembly assembly=  Assembly.GetExecutingAssembly();

            Type controllerType = assembly.GetType($"CRUDUsingEFDBFirstApproach.Controllers.{controllerName}Controller");
            object instance= Activator.CreateInstance(controllerType);

            MethodInfo method= controllerType.GetMethod(actionName);

            object result=  method.Invoke(instance, new object[] { value?.ToString() });

            JsonResult jsonResult = result as JsonResult;

              bool isValid= (bool)jsonResult.Data;

            return isValid;

          //  return base.IsValid(value);
        }
    }
}