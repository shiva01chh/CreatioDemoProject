namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EntityProcessElementDataOwnerAsyncExecutorSchema

	/// <exclude/>
	public class EntityProcessElementDataOwnerAsyncExecutorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EntityProcessElementDataOwnerAsyncExecutorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EntityProcessElementDataOwnerAsyncExecutorSchema(EntityProcessElementDataOwnerAsyncExecutorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("232b7840-ec6e-489d-a023-bb9b694170a3");
			Name = "EntityProcessElementDataOwnerAsyncExecutor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,84,75,107,227,48,16,62,167,208,255,48,116,47,54,20,249,222,166,129,146,154,146,195,182,133,237,238,93,149,199,142,88,91,50,122,36,107,74,255,251,202,35,59,137,219,122,97,161,190,141,102,190,135,62,73,86,188,65,219,114,129,240,140,198,112,171,75,199,214,90,149,178,242,134,59,169,213,249,217,235,249,217,194,91,169,42,248,209,89,135,205,245,161,62,133,52,141,86,159,119,12,206,173,179,92,57,233,36,90,118,107,59,37,30,91,140,154,246,191,1,108,163,28,154,50,236,163,199,6,244,55,131,85,104,192,186,230,214,94,1,225,186,39,163,195,128,205,107,108,80,185,59,238,120,164,217,43,52,132,202,178,12,150,214,55,13,55,221,106,168,137,1,246,82,108,1,255,160,240,14,45,232,81,24,74,109,64,108,185,170,122,179,186,39,2,93,2,146,28,180,81,15,48,10,90,40,130,36,131,81,40,59,81,106,253,75,45,5,8,18,155,115,75,70,201,114,78,78,130,246,21,108,226,116,190,11,67,211,84,2,237,43,109,235,144,198,119,116,91,93,132,60,158,72,46,54,223,111,122,88,64,4,97,176,188,185,152,23,96,209,6,94,100,71,156,193,192,243,219,174,242,143,89,189,116,199,168,62,141,38,6,200,150,217,72,114,96,61,141,106,204,106,167,101,1,131,76,242,211,162,9,247,86,161,32,41,63,41,47,97,118,11,183,166,178,192,77,229,201,69,10,253,101,95,44,118,220,28,125,211,200,13,36,145,131,206,96,134,40,61,16,93,31,105,250,249,225,40,55,170,212,129,73,225,190,127,74,51,231,75,67,209,198,34,74,110,138,0,154,216,97,99,227,50,206,61,224,62,98,231,38,215,186,246,141,250,197,107,31,222,206,61,186,231,174,197,130,202,229,189,151,197,42,153,130,136,44,98,30,194,15,34,29,100,30,235,98,78,38,180,190,80,233,45,230,247,239,160,146,233,33,167,108,221,95,46,76,222,39,158,18,217,219,240,18,80,21,241,49,80,29,87,167,139,97,45,124,127,1,85,79,236,5,25,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("232b7840-ec6e-489d-a023-bb9b694170a3"));
		}

		#endregion

	}

	#endregion

}

