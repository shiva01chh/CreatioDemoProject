namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EntityOwnerEventAsyncOperationArgsSchema

	/// <exclude/>
	public class EntityOwnerEventAsyncOperationArgsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EntityOwnerEventAsyncOperationArgsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EntityOwnerEventAsyncOperationArgsSchema(EntityOwnerEventAsyncOperationArgsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6eeec1f5-f32a-4553-8347-9fd59c89add8");
			Name = "EntityOwnerEventAsyncOperationArgs";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,83,203,106,195,48,16,60,59,144,127,88,220,75,10,197,190,231,97,8,33,135,92,154,64,251,3,138,178,54,2,91,50,90,169,169,27,250,239,149,228,7,78,73,72,124,48,214,238,236,236,236,172,44,89,133,84,51,142,240,137,90,51,82,185,73,54,74,230,162,176,154,25,161,228,116,114,153,78,34,75,66,22,240,209,144,193,106,49,156,199,37,26,147,173,52,194,8,164,135,128,100,77,141,228,251,26,219,22,190,192,149,188,104,44,220,9,54,37,35,154,67,0,55,251,179,68,189,253,66,105,174,107,214,186,160,80,149,166,41,44,201,86,21,211,77,214,157,215,167,147,240,32,86,130,242,245,192,116,97,43,199,65,96,20,212,142,30,132,116,95,248,141,220,26,165,147,158,39,29,17,213,246,88,10,14,220,171,121,66,76,47,248,174,214,232,18,244,14,99,30,180,114,0,111,199,28,14,161,87,155,255,63,80,8,188,187,53,129,202,1,67,143,110,42,174,74,91,201,100,40,26,171,239,229,147,209,126,17,65,249,38,224,3,213,5,10,52,11,32,255,250,237,116,161,60,181,210,174,117,186,219,224,72,44,119,62,61,163,116,39,157,245,172,20,63,72,32,241,236,140,38,195,36,15,234,151,132,8,92,99,190,138,31,27,26,167,217,237,201,66,164,102,154,85,32,221,44,171,184,53,37,206,90,206,100,153,134,228,29,108,104,230,233,179,157,204,21,176,163,178,102,184,31,16,210,116,69,209,25,249,88,240,172,133,116,59,122,131,109,223,10,134,166,175,48,135,35,35,156,245,152,81,198,255,102,209,237,93,180,209,113,48,154,78,92,208,61,127,51,134,29,113,192,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6eeec1f5-f32a-4553-8347-9fd59c89add8"));
		}

		#endregion

	}

	#endregion

}

