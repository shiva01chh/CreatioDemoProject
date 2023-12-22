namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IImapSyncSessionSchema

	/// <exclude/>
	public class IImapSyncSessionSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IImapSyncSessionSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IImapSyncSessionSchema(IImapSyncSessionSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b5e207e3-b931-420a-8ad6-b7eb4a279b1a");
			Name = "IImapSyncSession";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("80eb4b00-d20b-4335-a2cc-1f02c0e63f83");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,145,193,106,132,48,16,134,207,10,190,195,192,94,218,139,222,215,82,40,219,139,7,65,106,95,32,171,163,27,48,137,100,226,130,93,250,238,157,24,187,88,108,161,57,37,147,249,255,124,243,71,11,133,52,138,6,225,29,173,21,100,58,151,150,66,14,73,124,75,98,224,53,145,212,61,212,51,57,84,121,18,39,113,116,176,216,75,163,161,208,14,109,199,210,35,20,133,18,99,61,235,166,70,34,190,91,250,178,44,131,39,154,148,18,118,126,94,207,149,53,87,217,34,129,66,119,49,45,65,103,44,20,229,75,5,196,234,139,53,90,126,8,231,221,165,119,23,141,223,167,223,102,217,198,109,156,206,131,108,66,155,135,216,49,48,213,171,164,209,144,56,15,200,2,158,39,186,179,51,199,136,214,73,164,35,84,139,211,130,188,99,94,10,111,168,140,67,104,46,66,247,8,146,131,32,104,204,164,93,122,151,108,201,34,102,90,53,167,69,66,39,223,12,55,232,209,229,240,25,94,58,160,110,3,204,122,94,201,202,16,204,63,176,106,39,172,35,144,60,54,40,254,178,93,132,20,130,248,131,242,106,100,11,62,47,159,155,255,242,135,199,252,87,180,0,252,179,200,181,237,250,2,6,247,177,8,70,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b5e207e3-b931-420a-8ad6-b7eb4a279b1a"));
		}

		#endregion

	}

	#endregion

}

