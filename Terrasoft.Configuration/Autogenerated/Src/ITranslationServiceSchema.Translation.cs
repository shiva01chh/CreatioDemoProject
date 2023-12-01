namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ITranslationServiceSchema

	/// <exclude/>
	public class ITranslationServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ITranslationServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ITranslationServiceSchema(ITranslationServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8368303c-f5ee-4bf3-920a-9f76b46f2286");
			Name = "ITranslationService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6d72ca66-8680-4c3f-b4a0-15ba7a19db7c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,221,83,205,138,194,48,24,60,87,240,29,66,189,84,40,125,0,101,15,174,176,208,133,174,98,11,30,196,67,76,191,214,96,155,100,147,180,208,149,125,247,141,137,21,69,241,238,230,148,76,102,230,251,38,63,12,215,160,4,38,128,50,144,18,43,94,232,104,206,89,65,203,70,98,77,57,139,50,137,153,170,236,124,56,56,14,7,94,163,40,43,81,218,41,13,117,148,130,108,41,129,132,231,80,77,159,109,70,107,216,25,130,161,140,36,148,198,12,197,76,131,44,76,233,9,138,175,138,156,69,150,186,57,47,76,71,90,98,162,131,47,211,46,122,67,254,61,223,31,111,141,64,52,187,138,18,68,123,235,199,206,222,209,186,95,58,73,64,239,121,174,38,104,105,229,110,115,179,16,224,142,160,175,190,181,176,201,17,179,150,31,32,112,178,83,59,203,69,154,249,33,90,193,119,3,74,127,112,89,99,109,112,67,77,64,41,92,130,131,162,79,197,89,136,222,121,222,165,186,171,224,134,114,65,163,181,196,66,64,30,158,202,121,43,115,61,156,41,120,110,106,195,123,45,167,57,154,17,221,224,138,254,192,85,242,96,60,125,217,80,247,23,216,171,209,76,136,170,251,255,49,231,123,32,135,71,49,71,192,114,247,132,237,250,215,125,175,27,208,98,102,252,1,178,50,239,95,232,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8368303c-f5ee-4bf3-920a-9f76b46f2286"));
		}

		#endregion

	}

	#endregion

}

