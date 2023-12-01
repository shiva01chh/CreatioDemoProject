namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DCRepositoryReadOptionsSchema

	/// <exclude/>
	public class DCRepositoryReadOptionsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DCRepositoryReadOptionsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DCRepositoryReadOptionsSchema(DCRepositoryReadOptionsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e1294a92-73db-463a-b908-32d204d88db2");
			Name = "DCRepositoryReadOptions";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("ad993b20-8db8-48d6-9762-5a83fb4975c6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,146,65,110,194,48,16,69,215,69,226,14,163,116,91,37,130,101,9,217,192,182,5,161,92,96,26,38,193,146,99,91,182,211,42,66,220,189,19,39,1,65,131,84,47,44,249,207,255,158,241,147,21,214,228,12,22,4,57,89,139,78,151,62,222,104,85,138,170,177,232,133,86,241,182,85,88,139,130,69,79,202,207,103,231,249,236,165,113,66,85,255,76,196,31,250,72,210,173,230,51,14,190,90,170,216,2,27,137,206,189,195,118,115,32,163,157,240,218,182,7,194,227,206,116,23,184,96,77,146,4,82,215,212,53,218,54,27,206,55,55,232,222,10,165,182,96,57,234,192,83,109,36,122,138,199,112,242,144,78,125,107,200,160,197,26,120,64,90,71,249,34,202,242,33,5,69,55,82,156,38,87,211,243,216,50,202,120,18,41,10,156,78,153,230,139,139,125,237,217,27,211,124,241,6,249,50,131,159,19,89,166,191,232,104,140,195,4,100,99,101,57,112,234,250,133,2,119,56,7,68,87,156,123,171,13,89,47,136,153,238,67,243,190,254,200,48,8,187,145,156,196,106,146,31,108,169,196,70,122,248,70,217,16,8,199,119,16,3,178,84,174,163,219,144,183,199,196,159,90,81,148,92,59,220,145,31,105,76,5,225,175,228,224,12,21,249,21,184,110,187,192,122,50,24,58,174,6,8,164,142,61,135,112,190,244,31,237,78,100,141,215,47,180,155,21,29,236,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e1294a92-73db-463a-b908-32d204d88db2"));
		}

		#endregion

	}

	#endregion

}

