﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotChocolate.Fetching.Properties {
    using System;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class FetchingResources {
        
        private static System.Resources.ResourceManager resourceMan;
        
        private static System.Globalization.CultureInfo resourceCulture;
        
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal FetchingResources() {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static System.Resources.ResourceManager ResourceManager {
            get {
                if (object.Equals(null, resourceMan)) {
                    System.Resources.ResourceManager temp = new System.Resources.ResourceManager("HotChocolate.Fetching.Properties.FetchingResources", typeof(FetchingResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        internal static string DataLoaderRegistry_KeyNullOrEmpty {
            get {
                return ResourceManager.GetString("DataLoaderRegistry_KeyNullOrEmpty", resourceCulture);
            }
        }
        
        internal static string DefaultDataLoaderRegistry_GetOrRegister {
            get {
                return ResourceManager.GetString("DefaultDataLoaderRegistry_GetOrRegister", resourceCulture);
            }
        }
        
        internal static string DataLoaderResolverContextExtensions_CreateDataLoader_AbstractType {
            get {
                return ResourceManager.GetString("DataLoaderResolverContextExtensions_CreateDataLoader_AbstractType", resourceCulture);
            }
        }
        
        internal static string DataLoaderResolverContextExtensions_CreateDataLoader_UnableToCreate {
            get {
                return ResourceManager.GetString("DataLoaderResolverContextExtensions_CreateDataLoader_UnableToCreate", resourceCulture);
            }
        }
        
        internal static string DataLoaderResolverContextExtensions_RegistryIsNull {
            get {
                return ResourceManager.GetString("DataLoaderResolverContextExtensions_RegistryIsNull", resourceCulture);
            }
        }
        
        internal static string DataLoaderResolverContextExtensions_UnableToRegister {
            get {
                return ResourceManager.GetString("DataLoaderResolverContextExtensions_UnableToRegister", resourceCulture);
            }
        }
        
        internal static string ThrowHelper_DataLoader_InvalidType {
            get {
                return ResourceManager.GetString("ThrowHelper_DataLoader_InvalidType", resourceCulture);
            }
        }
    }
}
