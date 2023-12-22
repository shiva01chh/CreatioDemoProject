namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EntityActivityOwnerAsyncExecutorSchema

	/// <exclude/>
	public class EntityActivityOwnerAsyncExecutorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EntityActivityOwnerAsyncExecutorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EntityActivityOwnerAsyncExecutorSchema(EntityActivityOwnerAsyncExecutorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ac041bc6-71d1-475e-a18c-3ab49a0d8e36");
			Name = "EntityActivityOwnerAsyncExecutor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,84,75,111,219,48,12,62,167,64,255,3,209,93,108,160,176,239,109,26,32,8,130,34,135,181,3,218,237,174,202,180,45,204,150,2,61,146,25,69,255,251,36,202,142,237,110,62,12,88,46,129,72,126,15,82,148,37,107,209,28,25,71,120,69,173,153,81,165,205,118,74,150,162,114,154,89,161,228,245,213,251,245,213,202,25,33,43,120,233,140,197,246,254,114,158,66,218,86,201,191,103,52,46,197,179,189,180,194,10,52,217,214,116,146,63,31,49,106,154,127,6,100,7,105,81,151,190,143,128,245,232,47,26,43,159,128,93,195,140,185,3,194,117,91,110,197,41,252,19,248,44,81,83,109,158,231,176,54,174,109,153,238,54,253,153,112,112,22,188,6,252,133,220,89,52,160,6,57,40,149,6,94,51,89,5,139,42,16,129,42,1,73,4,88,84,9,46,97,96,207,39,244,71,247,214,8,14,156,20,230,198,200,19,185,219,147,168,151,185,131,67,172,217,159,60,255,188,109,79,246,78,29,92,218,253,138,182,86,133,111,248,27,137,196,228,231,254,250,0,34,112,141,229,195,205,178,64,22,109,224,77,62,226,52,122,158,159,102,179,255,115,44,111,29,88,205,164,41,81,135,193,140,131,152,76,39,78,203,42,176,53,130,196,243,44,158,173,243,129,254,162,55,29,221,48,187,147,18,5,244,6,146,239,6,181,95,89,137,156,76,184,217,241,22,22,155,219,234,202,0,211,149,107,125,202,164,16,246,124,181,58,49,61,118,68,37,15,144,68,14,186,157,5,162,244,66,116,63,210,80,61,65,15,178,84,158,40,244,59,187,113,63,27,98,165,124,52,176,234,17,133,175,159,25,201,134,196,109,172,123,194,115,196,46,85,238,84,227,90,249,131,53,206,175,226,35,218,215,238,136,5,29,215,143,78,20,155,100,14,34,178,136,121,242,95,133,180,151,121,110,138,37,25,159,250,159,74,145,235,133,215,126,5,66,124,161,173,177,128,96,31,113,224,139,163,77,230,11,145,102,187,240,112,49,249,116,59,41,209,124,244,207,9,101,17,95,20,157,99,116,30,244,177,233,239,55,162,114,212,75,72,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ac041bc6-71d1-475e-a18c-3ab49a0d8e36"));
		}

		#endregion

	}

	#endregion

}

