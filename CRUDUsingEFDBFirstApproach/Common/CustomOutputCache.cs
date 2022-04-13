using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;

namespace CRUDUsingEFDBFirstApproach.Common
{
    public class CustomOutputCache : OutputCacheAttribute
    {
        
            public CustomOutputCache(string cacheProfile)
            {
                var settings = (OutputCacheSettingsSection)
                WebConfigurationManager.
                GetSection("system.web/caching/outputCacheSettings");
                var profile = settings.OutputCacheProfiles[cacheProfile];
                Duration = profile.Duration;
                VaryByParam = profile.VaryByParam;
                VaryByCustom = profile.VaryByCustom;
            }
        }
    }
