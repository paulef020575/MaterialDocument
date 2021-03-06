﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MaterialDocument.Resources.Doc {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class MaterialPermit {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal MaterialPermit() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MaterialDocument.Resources.Doc.MaterialPermit", typeof(MaterialPermit).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to execute procedure docMaterialPermitDelete(@id, @modifier).
        /// </summary>
        public static string Delete {
            get {
                return ResourceManager.GetString("Delete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to select * from DOCPERMITLOADBYNUM(NULL, @number).
        /// </summary>
        public static string FindAutoPermit {
            get {
                return ResourceManager.GetString("FindAutoPermit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to gen_docMaterialPermit_id.
        /// </summary>
        public static string GeneratorName {
            get {
                return ResourceManager.GetString("GeneratorName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to select distinct lower(baseDocument) from docMaterialPermit where baseDocument is not null order by  lower(baseDocument).
        /// </summary>
        public static string GetBaseDocumentList {
            get {
                return ResourceManager.GetString("GetBaseDocumentList", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to select comment from docMaterialPermit where id = @id.
        /// </summary>
        public static string GetComment {
            get {
                return ResourceManager.GetString("GetComment", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to select max(date1)
        ///    from
        ///        (select max(modifyDate) as date1
        ///            from docMaterialPermit
        ///            where unitId = @unitId
        ///         union
        ///         select max(operationDate) as date1
        ///            from dochistory
        ///            where documentType = &apos;materialPermit&apos;
        ///              and operation = &apos;delete&apos;).
        /// </summary>
        public static string GetLastDate {
            get {
                return ResourceManager.GetString("GetLastDate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to select m.name as vehicleMark, v.licensePlate from refVehicle v, refVehicleMark m where m.id = v.vehicleMark and v.id = @id.
        /// </summary>
        public static string GetVehicle {
            get {
                return ResourceManager.GetString("GetVehicle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to execute procedure docMaterialPermitInsert(@id, @UNITID, @DOCNUMBER, @DOCDATE, @PERSON, @VEHICLEMARK, @LICENSEPLATE, @CREATEFLAG, @CREATOR, @CREATEDATE, @SIGNEDFLAG, @SIGNER, @SIGNDATE, @ENTRYFLAG, @ENTRYPOINT, @ENTRYDATE, @COMMENT, @MODIFIER, @autoPermit, @baseDocument, @baseDocNumber, @baseDocDate).
        /// </summary>
        public static string Insert {
            get {
                return ResourceManager.GetString("Insert", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to delete from docMaterialPermitItem where id = @id.
        /// </summary>
        public static string ItemDelete {
            get {
                return ResourceManager.GetString("ItemDelete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to gen_docMaterialPermitItem_id.
        /// </summary>
        public static string ItemGeneratorName {
            get {
                return ResourceManager.GetString("ItemGeneratorName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to insert into docMaterialPermitItem (id, document, material, materialUnit, quantity, tonnage) values (@id, @document, @material, @materialUnit, @quantity, @tonnage).
        /// </summary>
        public static string ItemInsert {
            get {
                return ResourceManager.GetString("ItemInsert", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to select * from docMaterialPermitItem where document = @document.
        /// </summary>
        public static string ItemLoadList {
            get {
                return ResourceManager.GetString("ItemLoadList", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to update docMaterialPermitItem set material = @material, materialUnit = @materialUnit, quantity = @quantity, tonnage = @tonnage where id = @id.
        /// </summary>
        public static string ItemUpdate {
            get {
                return ResourceManager.GetString("ItemUpdate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to select * from docMaterialPermitLoadList(@id, NULL, NULL, NULL, NULL).
        /// </summary>
        public static string Load {
            get {
                return ResourceManager.GetString("Load", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to select * from docPermitLoad(@permitid).
        /// </summary>
        public static string LoadAutoPermit {
            get {
                return ResourceManager.GetString("LoadAutoPermit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to select * from docMaterialPermitLoadList(NULL, @unitId, @dateFrom, @dateTo, @userId).
        /// </summary>
        public static string LoadList {
            get {
                return ResourceManager.GetString("LoadList", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to update docMaterialPermit set createFlag = @createFlag, creator = @creator, createDate = @createDate, modifier = @modifier, modifyDate = @modifyDate where id = @id.
        /// </summary>
        public static string MarkAsCreated {
            get {
                return ResourceManager.GetString("MarkAsCreated", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to update docMaterialPermit set signedFlag = @signedFlag, signer = @signer, signDate = @signDate, modifier = @modifier, modifyDate = @modifyDate where id = @id.
        /// </summary>
        public static string MarkAsSigned {
            get {
                return ResourceManager.GetString("MarkAsSigned", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to update docMaterialPermit set comment = @comment, modifier = @modifier, modifyDate = @modifyDate where id = @id.
        /// </summary>
        public static string SetComment {
            get {
                return ResourceManager.GetString("SetComment", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to execute procedure docMaterialPermitUpdate(@ID, @UNITID, @DOCNUMBER, @DOCDATE, @PERSON, @VEHICLEMARK, @LICENSEPLATE, @CREATEFLAG, @CREATOR, @CREATEDATE, @SIGNEDFLAG, @SIGNER, @SIGNDATE, @ENTRYFLAG, @ENTRYPOINT, @ENTRYDATE, @COMMENT, @MODIFIER, @autoPermit, @baseDocument, @baseDocNumber, @baseDocDate).
        /// </summary>
        public static string Update {
            get {
                return ResourceManager.GetString("Update", resourceCulture);
            }
        }
    }
}
