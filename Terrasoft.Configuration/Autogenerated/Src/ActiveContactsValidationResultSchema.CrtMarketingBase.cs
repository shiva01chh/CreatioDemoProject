namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ActiveContactsValidationResultSchema

	/// <exclude/>
	public class ActiveContactsValidationResultSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ActiveContactsValidationResultSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ActiveContactsValidationResultSchema(ActiveContactsValidationResultSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("45311f20-f594-44c6-8b97-79025c4a6695");
			Name = "ActiveContactsValidationResult";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("8ded9bc0-26e3-4d8b-ab12-46857e761bcf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,146,81,75,195,48,20,133,159,91,232,127,184,176,247,198,189,58,21,180,248,40,12,21,223,99,122,23,2,109,82,114,111,6,99,248,223,77,19,187,117,34,174,121,8,228,112,206,249,146,75,172,236,145,6,169,16,222,209,123,73,110,199,117,227,236,206,232,224,37,27,103,171,242,88,149,85,9,113,173,60,234,168,64,211,73,162,91,120,84,108,246,24,205,44,21,211,135,236,76,155,18,175,72,161,227,41,36,132,128,59,10,125,47,253,225,225,44,61,73,66,216,159,50,224,83,168,158,101,196,101,104,8,159,157,81,160,70,246,85,116,145,238,92,20,191,224,89,56,219,129,130,82,72,84,159,188,98,110,158,144,206,18,131,177,12,111,217,14,247,112,179,89,6,136,51,117,126,105,253,243,104,142,229,235,159,242,105,222,91,239,6,244,108,48,14,125,155,66,203,224,202,181,248,63,123,164,54,209,5,71,208,200,27,160,113,251,90,214,30,255,13,73,125,5,64,236,141,213,240,146,189,127,97,86,104,219,252,206,116,206,234,165,152,180,249,250,6,210,162,147,204,181,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("45311f20-f594-44c6-8b97-79025c4a6695"));
		}

		#endregion

	}

	#endregion

}

