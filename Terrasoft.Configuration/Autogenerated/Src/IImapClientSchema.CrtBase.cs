namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IImapClientSchema

	/// <exclude/>
	public class IImapClientSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IImapClientSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IImapClientSchema(IImapClientSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4eefcdc0-dfe1-496a-a1c1-f92ded0404ac");
			Name = "IImapClient";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("80eb4b00-d20b-4335-a2cc-1f02c0e63f83");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,145,209,106,131,48,24,133,175,45,244,29,2,189,105,97,248,0,237,216,141,237,138,48,71,97,190,64,212,163,13,196,68,242,199,110,101,236,221,247,107,92,39,133,134,8,254,199,143,227,201,137,145,45,168,147,37,68,14,231,36,217,218,199,153,84,122,185,248,94,46,162,158,148,105,196,199,149,60,218,221,221,28,39,86,107,148,94,89,67,241,17,6,78,149,204,48,181,114,104,88,21,169,241,112,53,123,111,69,154,182,178,75,180,130,241,12,240,238,250,66,171,82,168,63,100,78,48,190,87,212,89,146,133,6,179,67,146,155,105,6,127,182,21,109,197,105,116,24,127,24,21,214,106,145,187,235,30,26,30,175,86,87,112,107,242,110,72,91,143,211,59,159,115,179,187,177,137,131,188,7,13,62,131,112,146,254,28,216,139,85,149,200,236,5,25,136,100,131,220,62,242,126,18,147,212,78,164,242,250,95,172,192,141,25,57,116,21,12,102,81,14,134,122,55,69,57,124,41,242,244,40,249,27,127,124,30,123,10,244,139,56,194,135,87,90,111,66,247,209,10,166,10,85,13,19,63,63,225,78,102,50,43,195,250,5,244,187,80,127,251,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4eefcdc0-dfe1-496a-a1c1-f92ded0404ac"));
		}

		#endregion

	}

	#endregion

}

