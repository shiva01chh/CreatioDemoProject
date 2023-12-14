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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,84,75,107,227,48,16,62,167,208,255,48,116,47,54,20,251,222,166,129,16,66,201,97,219,133,62,238,170,60,182,197,218,82,208,35,89,83,250,223,87,26,217,113,220,93,31,10,205,37,104,102,190,199,140,70,150,172,69,179,103,28,225,25,181,102,70,149,54,219,40,89,138,202,105,102,133,146,151,23,239,151,23,11,103,132,172,224,169,51,22,219,219,211,249,28,210,182,74,254,63,163,113,46,158,109,165,21,86,160,201,214,166,147,252,113,143,81,211,124,25,144,237,164,69,93,250,62,2,214,163,127,104,172,124,2,54,13,51,230,6,8,215,173,185,21,135,240,79,224,163,68,77,181,121,158,195,210,184,182,101,186,91,245,103,194,193,81,240,26,240,15,114,103,209,128,26,228,160,84,26,120,205,100,21,44,170,64,4,170,4,36,17,96,81,37,184,132,129,61,63,163,223,187,183,70,112,224,164,48,53,70,158,200,221,150,68,189,204,13,236,98,205,246,224,249,167,109,123,178,119,234,224,212,238,79,180,181,42,124,195,191,72,36,38,63,247,215,7,16,129,107,44,239,174,230,5,178,104,3,175,242,17,167,209,243,252,54,171,237,191,99,121,235,192,106,38,77,137,58,12,102,28,196,217,116,226,180,172,2,91,35,72,60,78,226,217,50,31,232,79,122,231,163,27,102,119,80,162,128,222,64,242,98,80,251,149,149,200,201,132,155,28,175,97,182,185,181,174,12,48,93,185,214,167,76,10,97,207,23,139,3,211,99,71,84,114,7,73,228,160,219,153,33,74,79,68,183,35,13,213,19,116,39,75,229,137,66,191,147,27,247,179,33,86,202,71,3,139,30,81,248,250,137,145,108,72,92,199,186,7,60,70,236,92,229,70,53,174,149,175,172,113,126,21,239,209,62,119,123,44,232,184,188,119,162,88,37,83,16,145,69,204,131,255,42,164,189,204,99,83,204,201,248,212,119,42,69,174,39,94,251,21,8,241,153,182,198,2,130,125,196,129,207,142,54,153,46,68,154,109,194,195,197,228,211,237,164,68,243,209,63,39,148,69,124,81,116,142,209,105,208,199,194,239,47,230,173,118,222,64,5,0,0 };
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

