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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,146,81,107,194,48,20,133,159,21,252,15,23,246,110,223,173,236,101,67,233,195,64,54,113,207,209,158,102,129,38,41,55,105,199,24,251,239,75,82,171,206,205,161,133,208,155,147,123,191,220,147,196,8,13,215,136,29,104,13,102,225,108,229,167,15,214,84,74,182,44,188,178,102,186,132,65,8,81,190,98,187,176,172,95,192,157,218,97,50,254,156,140,71,173,83,70,94,44,93,168,26,133,110,44,251,124,50,14,217,119,12,25,116,42,140,7,87,97,211,25,21,123,106,159,182,18,44,180,219,239,104,57,21,101,89,70,115,215,106,45,248,227,126,63,95,177,237,84,9,71,106,32,81,101,153,84,130,80,19,41,8,11,142,100,143,138,205,12,168,236,132,213,180,219,90,237,78,40,255,182,67,199,118,159,225,218,218,23,166,178,129,18,15,98,20,199,224,47,180,215,128,189,130,155,209,42,109,145,156,252,178,146,132,37,188,163,0,119,241,239,223,64,37,42,17,224,212,137,186,5,105,97,132,4,79,15,245,217,57,96,158,18,15,211,245,21,136,99,69,241,216,167,110,162,242,212,39,210,95,90,50,57,146,240,57,165,40,180,155,199,224,235,122,99,114,120,73,244,142,109,188,48,29,27,84,101,60,219,219,252,93,73,58,177,121,254,138,55,67,58,93,94,57,90,62,119,156,46,27,166,236,239,59,205,123,245,167,152,180,240,125,3,34,229,217,249,101,3,0,0 };
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

