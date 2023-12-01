namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SysUserProfileQueryExecutorSchema

	/// <exclude/>
	public class SysUserProfileQueryExecutorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SysUserProfileQueryExecutorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SysUserProfileQueryExecutorSchema(SysUserProfileQueryExecutorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2874e500-f502-47f6-9bab-e93d028d1b70");
			Name = "SysUserProfileQueryExecutor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("400566f7-77a1-4986-aa86-a353b8b6c452");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,83,75,111,155,64,16,62,99,41,255,97,74,47,88,178,240,61,177,45,165,110,92,245,208,42,77,218,83,85,69,91,24,156,149,150,93,58,187,235,22,69,249,239,221,7,142,1,39,92,44,24,190,253,94,179,6,201,106,212,13,43,16,190,35,17,211,170,50,249,86,201,138,239,45,49,195,149,188,152,61,93,204,18,171,185,220,15,32,132,87,111,204,243,27,105,184,225,168,223,4,236,88,97,20,69,132,195,188,39,220,59,37,216,10,166,245,37,220,183,250,135,70,186,37,85,113,129,223,44,82,123,243,15,11,235,142,4,248,207,143,88,49,43,204,7,46,75,71,158,153,182,65,85,101,159,131,108,59,192,207,23,240,213,5,132,53,164,19,172,233,252,151,163,109,236,111,193,11,40,188,137,41,15,112,9,175,73,57,134,167,96,239,37,206,142,163,40,93,158,91,226,7,102,48,126,108,226,11,16,178,82,73,209,130,151,113,133,75,44,124,219,240,96,7,239,87,29,37,202,50,178,14,37,28,80,27,178,190,77,47,20,18,116,58,49,205,68,142,108,164,60,20,158,131,95,123,146,140,252,184,38,207,12,38,201,243,180,203,47,104,30,85,57,50,184,92,46,97,165,109,93,51,106,55,199,193,29,26,75,82,7,13,104,162,233,252,5,189,28,195,87,13,35,86,131,191,195,235,212,97,13,146,78,55,187,248,144,175,150,225,243,9,77,145,125,51,44,5,116,76,226,15,28,17,189,6,227,170,183,74,136,174,129,79,104,198,179,44,14,238,139,71,172,89,40,25,80,255,57,86,120,96,4,24,0,119,168,149,56,184,104,235,120,215,227,255,160,205,29,229,106,107,137,28,106,232,237,120,96,147,73,252,219,223,246,53,237,109,237,224,89,80,72,210,225,82,210,197,248,30,205,231,97,81,73,52,26,250,237,36,186,201,122,100,209,123,234,44,245,252,100,29,141,143,84,156,42,89,131,183,119,214,202,200,195,98,44,209,111,173,35,230,21,100,231,230,222,57,1,43,196,177,208,228,36,157,95,151,229,249,129,142,236,57,252,198,157,246,236,78,92,217,56,29,14,195,108,54,251,15,78,252,170,134,42,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2874e500-f502-47f6-9bab-e93d028d1b70"));
		}

		#endregion

	}

	#endregion

}

