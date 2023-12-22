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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,221,83,205,138,194,48,24,60,87,240,29,66,189,84,40,125,0,101,15,174,176,208,133,174,98,11,30,196,67,108,191,214,96,154,100,147,180,208,149,125,247,141,137,21,69,241,238,230,148,76,102,230,251,38,63,12,215,160,4,206,1,101,32,37,86,188,212,209,156,179,146,84,141,196,154,112,22,101,18,51,69,237,124,56,56,14,7,94,163,8,171,80,218,41,13,117,148,130,108,73,14,9,47,128,78,159,109,70,107,216,25,130,161,140,36,84,198,12,197,76,131,44,77,233,9,138,175,138,156,69,150,186,57,47,76,71,90,226,92,7,95,166,93,244,134,252,123,190,63,222,26,129,104,118,148,228,136,244,214,143,157,189,163,117,191,116,146,128,222,243,66,77,208,210,202,221,230,102,33,192,29,65,95,125,107,97,147,35,102,45,63,64,224,100,167,118,150,139,52,243,67,180,130,239,6,148,254,224,178,198,218,224,134,154,128,82,184,2,7,69,159,138,179,16,189,243,162,75,117,71,225,134,114,65,163,181,196,66,64,17,158,202,121,43,115,61,156,41,120,110,106,195,123,45,39,5,154,229,186,193,148,252,192,85,242,96,60,125,217,80,247,23,216,171,209,76,8,218,253,255,152,243,61,228,135,71,49,71,192,10,247,132,237,250,215,125,175,27,208,98,215,227,15,144,82,230,124,241,3,0,0 };
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

