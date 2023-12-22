namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EmailHeaderModelSchema

	/// <exclude/>
	public class EmailHeaderModelSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EmailHeaderModelSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EmailHeaderModelSchema(EmailHeaderModelSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2d6eaf3b-23d3-462e-bed5-b0973014733e");
			Name = "EmailHeaderModel";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("05bb6355-677b-44f1-8326-8d7c3ae660cf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,146,193,78,195,48,12,134,207,171,180,119,176,180,123,123,167,136,203,64,112,1,42,216,11,164,157,219,5,210,164,178,147,195,84,241,238,184,9,157,42,180,195,6,85,165,202,206,111,255,159,254,198,170,30,121,80,13,194,14,137,20,187,214,231,91,103,91,221,5,82,94,59,187,206,198,117,182,10,172,109,7,239,71,246,216,151,82,203,187,33,236,228,28,182,70,49,223,192,67,175,180,121,66,181,71,122,118,123,52,235,76,52,69,81,192,45,135,190,87,116,188,251,169,223,112,32,100,180,158,225,126,247,10,174,133,67,156,98,104,29,129,63,32,212,193,124,2,78,251,64,236,6,163,60,230,243,178,98,177,109,8,181,209,13,52,19,192,25,255,213,24,25,78,160,21,185,1,201,107,20,218,42,142,166,243,223,144,177,241,136,194,39,60,60,125,133,86,214,130,149,172,242,211,196,146,100,70,97,79,49,167,168,127,17,57,140,208,161,47,167,53,37,124,93,233,23,35,184,194,48,70,240,55,199,41,246,148,56,135,250,3,27,127,153,109,210,254,215,82,238,67,186,2,23,153,86,179,250,156,237,70,130,72,191,59,214,169,187,108,74,103,249,124,3,111,173,159,23,255,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2d6eaf3b-23d3-462e-bed5-b0973014733e"));
		}

		#endregion

	}

	#endregion

}

