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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,145,193,106,132,48,16,134,207,10,190,195,192,94,218,139,222,215,82,40,219,139,7,65,106,95,32,171,163,6,76,34,153,184,96,151,190,123,39,198,46,91,108,161,57,37,147,249,255,124,243,71,11,133,52,137,6,225,29,173,21,100,58,151,150,66,142,73,124,77,98,224,53,147,212,61,212,11,57,84,121,18,39,113,116,176,216,75,163,161,208,14,109,199,210,35,20,133,18,83,189,232,166,70,34,190,91,251,178,44,131,39,154,149,18,118,121,222,206,149,53,23,217,34,129,66,55,152,150,160,51,22,138,242,165,2,98,245,96,141,150,31,194,121,119,233,221,69,227,247,233,183,89,118,231,54,205,231,81,54,161,205,67,236,24,152,234,85,210,100,72,156,71,100,1,207,19,221,216,153,99,66,235,36,210,17,170,213,105,69,222,49,175,133,55,84,198,33,52,131,208,61,130,228,32,8,26,51,107,151,222,36,247,100,17,51,109,154,211,42,161,147,111,134,43,244,232,114,248,12,47,29,80,183,1,102,59,111,100,101,8,230,31,88,181,19,214,17,72,30,27,20,127,217,46,66,10,65,252,65,121,49,178,5,159,151,207,205,127,249,195,99,254,43,90,0,254,89,228,154,95,95,70,56,159,159,62,2,0,0 };
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

