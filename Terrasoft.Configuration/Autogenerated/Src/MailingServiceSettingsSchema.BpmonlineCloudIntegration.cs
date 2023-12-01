namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MailingServiceSettingsSchema

	/// <exclude/>
	public class MailingServiceSettingsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MailingServiceSettingsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MailingServiceSettingsSchema(MailingServiceSettingsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("aab368d1-5d3d-4df2-8f5a-686ab5543ad8");
			Name = "MailingServiceSettings";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("fc1a2769-1cc9-44d3-a1a6-003d1b8450f5");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,145,193,78,195,48,12,134,207,155,180,119,176,182,11,92,218,59,3,36,180,33,78,67,19,133,19,226,144,181,110,137,72,147,202,113,38,141,137,119,199,77,215,177,77,67,130,92,42,59,255,87,127,73,172,170,209,55,42,71,120,70,34,229,93,201,201,204,217,82,87,129,20,107,103,147,217,125,182,112,5,26,63,26,110,71,195,65,240,218,86,144,109,60,99,157,60,5,203,186,198,36,67,210,202,232,207,72,76,71,67,201,77,8,43,41,96,102,148,247,87,176,80,218,8,40,193,181,206,49,67,102,169,124,76,166,105,10,215,62,212,181,162,205,237,174,238,3,224,74,224,119,132,220,184,80,128,239,232,164,135,210,3,234,117,174,88,137,57,147,202,249,77,26,77,88,25,157,11,41,243,127,29,63,216,70,133,189,237,146,92,131,196,26,69,121,25,127,208,237,159,58,198,198,3,178,8,146,104,201,183,181,180,114,153,189,113,67,110,173,11,164,100,143,31,218,118,186,11,172,87,72,23,143,45,118,3,227,30,25,95,182,254,253,1,60,83,123,227,203,221,102,12,111,161,66,158,182,131,167,240,245,87,67,101,193,53,141,35,14,86,243,6,216,65,173,62,126,68,161,192,82,5,195,255,16,14,30,123,173,59,63,239,240,99,249,149,115,6,94,206,196,206,29,97,130,182,232,222,33,214,93,247,184,25,123,178,190,1,182,205,229,84,183,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("aab368d1-5d3d-4df2-8f5a-686ab5543ad8"));
		}

		#endregion

	}

	#endregion

}

