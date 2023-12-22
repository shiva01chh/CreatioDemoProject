namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ITranslationErrorHandlerSchema

	/// <exclude/>
	public class ITranslationErrorHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ITranslationErrorHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ITranslationErrorHandlerSchema(ITranslationErrorHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("89e47229-db11-45c3-8172-96402d1727d6");
			Name = "ITranslationErrorHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("0b3cc894-bd0d-4e1b-bb7d-87203708d013");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,82,203,106,195,48,16,60,199,144,127,88,146,75,11,197,190,39,110,46,109,105,115,40,132,36,63,160,72,107,71,84,150,204,174,28,48,37,255,94,73,110,30,13,52,186,72,90,205,206,12,179,234,88,219,26,54,61,123,108,242,23,103,12,74,175,157,229,252,29,45,146,150,243,113,54,206,172,104,144,91,33,17,182,72,36,216,85,62,96,109,165,235,142,68,132,231,91,18,150,77,58,143,179,239,216,51,154,18,214,225,10,75,235,145,170,208,60,131,229,21,236,141,200,209,135,176,202,32,37,124,219,237,140,150,160,79,240,59,232,209,160,112,150,248,68,191,119,138,103,176,74,28,195,99,81,20,80,114,215,52,130,250,197,169,176,66,98,205,158,1,35,33,131,147,178,35,84,160,58,138,57,136,182,53,125,60,248,139,52,231,103,182,226,150,174,108,5,137,6,98,62,207,147,72,105,93,199,107,148,142,20,79,22,201,52,132,232,88,212,200,32,135,116,131,90,21,202,1,67,33,84,103,213,141,30,124,97,207,121,89,36,234,164,116,112,90,193,70,28,48,17,242,195,171,78,51,10,70,74,246,209,247,19,12,251,2,110,60,60,206,239,100,177,198,198,29,130,47,97,204,16,199,197,106,69,174,1,191,15,243,190,242,229,197,206,224,63,97,36,139,107,100,244,191,30,79,202,83,180,106,152,82,186,31,135,175,241,167,120,132,113,118,189,126,0,53,200,43,156,147,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("89e47229-db11-45c3-8172-96402d1727d6"));
		}

		#endregion

	}

	#endregion

}

