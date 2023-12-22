namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IWebFormImportParamsGeneratorSchema

	/// <exclude/>
	public class IWebFormImportParamsGeneratorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IWebFormImportParamsGeneratorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IWebFormImportParamsGeneratorSchema(IWebFormImportParamsGeneratorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5288477e-ed09-40b3-890c-492633a42375");
			Name = "IWebFormImportParamsGenerator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("9d05c8ee-17e3-41aa-adfe-7e36f0a4c27c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,146,81,107,194,48,20,133,159,21,252,15,23,246,110,223,85,246,178,161,244,97,32,155,184,231,104,79,179,64,147,148,155,212,49,198,254,251,146,180,213,206,205,161,133,208,155,147,123,191,220,147,196,8,13,87,139,61,104,3,102,225,108,233,167,15,214,148,74,54,44,188,178,102,186,130,65,8,81,188,98,183,180,172,95,192,7,181,199,100,252,57,25,143,26,167,140,188,88,186,84,21,114,93,91,246,243,201,56,100,223,49,100,208,41,55,30,92,134,77,103,148,119,212,54,109,45,88,104,215,237,104,57,21,101,89,70,11,215,104,45,248,227,190,155,175,217,30,84,1,71,170,39,81,105,153,84,130,80,29,41,8,11,142,100,139,138,205,244,168,108,192,170,155,93,165,246,3,202,191,237,208,169,221,103,184,166,242,185,41,109,160,196,131,24,197,209,251,11,237,213,96,175,224,102,180,78,91,36,39,191,172,36,97,5,239,40,192,93,252,251,55,80,129,82,4,56,29,68,213,128,180,48,66,130,167,199,250,236,28,176,72,137,199,233,230,10,196,169,34,127,108,83,183,81,121,106,19,233,47,45,153,28,73,248,57,165,40,180,59,143,193,215,245,198,100,255,146,232,29,187,120,97,58,54,168,138,120,182,183,249,187,146,52,176,121,254,138,183,125,58,93,94,57,89,62,119,156,46,27,166,104,239,59,205,91,245,167,152,180,225,247,13,48,13,93,190,110,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5288477e-ed09-40b3-890c-492633a42375"));
		}

		#endregion

	}

	#endregion

}

