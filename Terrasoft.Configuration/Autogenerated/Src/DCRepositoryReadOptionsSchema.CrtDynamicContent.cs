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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,146,65,110,194,48,16,69,215,69,226,14,163,116,91,37,130,101,9,217,192,182,5,161,92,96,26,38,169,37,199,182,198,78,171,8,113,247,58,78,2,133,6,169,94,88,242,159,255,61,227,39,43,172,201,26,44,8,114,98,70,171,75,23,111,180,42,69,213,48,58,161,85,188,109,21,214,162,240,162,35,229,230,179,211,124,246,212,88,161,170,127,38,226,55,125,36,105,87,243,153,15,62,51,85,222,2,27,137,214,190,194,118,115,32,163,173,112,154,219,3,225,113,103,186,11,108,176,38,73,2,169,109,234,26,185,205,134,243,213,13,186,183,66,169,25,216,71,45,56,170,141,68,71,241,24,78,238,210,169,107,13,25,100,172,193,15,72,235,40,95,68,89,62,164,160,232,70,138,211,228,98,122,28,91,70,153,159,68,138,2,167,83,166,249,240,197,190,246,232,141,105,190,120,129,124,153,193,247,39,177,167,191,232,104,140,195,4,100,99,101,57,112,234,250,133,130,239,112,10,136,46,56,247,172,13,177,19,228,153,238,67,243,190,126,207,48,8,187,145,156,196,106,146,31,108,169,196,70,58,248,66,217,16,8,235,239,32,15,136,169,92,71,215,33,175,143,137,223,181,162,40,185,116,184,33,63,210,152,10,194,95,201,194,9,42,114,43,176,221,118,134,245,100,48,116,92,13,16,72,29,123,14,225,124,238,63,218,141,232,181,223,235,7,77,25,96,56,245,2,0,0 };
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

