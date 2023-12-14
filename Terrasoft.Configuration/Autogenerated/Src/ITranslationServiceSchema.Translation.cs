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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,221,83,205,138,194,48,24,60,87,240,29,66,189,40,148,62,128,178,7,87,88,232,66,87,177,5,15,226,33,182,95,107,48,77,178,73,90,232,202,190,251,166,137,21,69,241,238,230,148,76,102,230,251,38,63,12,87,160,4,206,0,165,32,37,86,188,208,225,130,179,130,148,181,196,154,112,22,166,18,51,69,237,124,56,56,13,7,94,173,8,43,81,210,42,13,85,152,128,108,72,6,49,207,129,206,158,109,134,27,216,27,130,161,140,36,148,198,12,69,76,131,44,76,233,41,138,174,138,156,69,150,186,61,47,76,71,90,226,76,143,191,76,187,232,13,249,247,124,127,178,51,2,81,239,41,201,16,233,173,31,59,123,39,235,126,233,36,6,125,224,185,154,162,149,149,187,205,237,82,128,59,130,190,250,206,194,38,71,196,26,126,132,177,147,117,237,172,150,73,234,7,104,13,223,53,40,253,193,101,133,181,193,13,53,6,165,112,9,14,10,63,21,103,1,122,231,121,155,232,150,194,13,229,130,134,27,137,133,128,60,232,202,121,107,115,61,156,41,120,110,106,195,123,13,39,57,154,103,186,198,148,252,192,85,242,241,100,246,178,161,238,47,176,87,163,185,16,180,253,255,49,23,7,200,142,143,98,142,128,229,238,9,219,245,175,251,94,55,160,197,186,241,7,1,59,231,23,233,3,0,0 };
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

