﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Simul.Properties {
    using System;
    
    
    /// <summary>
    ///   Une classe de ressource fortement typée destinée, entre autres, à la consultation des chaînes localisées.
    /// </summary>
    // Cette classe a été générée automatiquement par la classe StronglyTypedResourceBuilder
    // à l'aide d'un outil, tel que ResGen ou Visual Studio.
    // Pour ajouter ou supprimer un membre, modifiez votre fichier .ResX, puis réexécutez ResGen
    // avec l'option /str ou régénérez votre projet VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Retourne l'instance ResourceManager mise en cache utilisée par cette classe.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Simul.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Remplace la propriété CurrentUICulture du thread actuel pour toutes
        ///   les recherches de ressources à l'aide de cette classe de ressource fortement typée.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Recherche une ressource localisée de type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap airplane {
            get {
                object obj = ResourceManager.GetObject("airplane", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Recherche une ressource localisée de type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap bread {
            get {
                object obj = ResourceManager.GetObject("bread", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Recherche une ressource localisée de type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap iron {
            get {
                object obj = ResourceManager.GetObject("iron", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot; ?&gt;
        ///&lt;!-- For valid reading, primary type resources needs to be put before 2nd and 3rd level resources --&gt;
        ///&lt;resources&gt;
        ///  &lt;resource&gt;
        ///    &lt;name&gt;wheat&lt;/name&gt;
        ///    &lt;type&gt;primary&lt;/type&gt;
        ///    &lt;improvedSkill&gt;farming&lt;/improvedSkill&gt;
        ///    &lt;productionCost&gt;1&lt;/productionCost&gt;
        ///  &lt;/resource&gt;
        ///  &lt;resource&gt;
        ///    &lt;name&gt;iron&lt;/name&gt;
        ///    &lt;type&gt;primary&lt;/type&gt;
        ///    &lt;improvedSkill&gt;mining&lt;/improvedSkill&gt;
        ///    &lt;productionCost&gt;2&lt;/productionCost&gt;
        ///  &lt;/resource&gt;
        ///  &lt;resource&gt;
        ///    &lt;name&gt;steel&lt;/ [le reste de la chaîne a été tronqué]&quot;;.
        /// </summary>
        internal static string resources {
            get {
                return ResourceManager.GetString("resources", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une ressource localisée de type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap steel {
            get {
                object obj = ResourceManager.GetObject("steel", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Recherche une ressource localisée de type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap weapon {
            get {
                object obj = ResourceManager.GetObject("weapon", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Recherche une ressource localisée de type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap wheat {
            get {
                object obj = ResourceManager.GetObject("wheat", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
    }
}
