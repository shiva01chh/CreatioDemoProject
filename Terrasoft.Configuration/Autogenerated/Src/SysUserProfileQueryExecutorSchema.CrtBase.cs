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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,83,75,111,155,64,16,62,19,41,255,97,74,47,88,178,224,158,24,75,169,27,87,61,180,74,147,246,84,85,213,22,6,103,165,101,161,179,187,110,81,148,255,222,125,64,12,184,193,7,203,12,223,126,175,89,131,100,53,170,150,21,8,95,145,136,169,166,210,233,174,145,21,63,24,98,154,55,242,242,226,233,242,34,50,138,203,195,4,66,120,253,202,60,189,149,154,107,142,234,85,192,158,21,186,161,128,176,152,183,132,7,171,4,59,193,148,186,130,135,78,125,83,72,119,212,84,92,224,23,131,212,221,254,197,194,216,35,30,254,253,61,86,204,8,253,142,203,210,146,39,186,107,177,169,146,143,94,182,155,224,87,107,248,108,3,66,14,241,2,107,188,250,97,105,91,243,75,240,2,10,103,98,201,3,92,193,255,164,44,195,147,183,247,18,103,207,81,148,54,207,29,241,35,211,24,94,182,225,1,8,89,217,72,209,129,147,177,133,75,44,92,219,240,211,76,158,175,123,74,148,101,96,157,74,88,160,210,100,92,155,78,200,39,232,117,66,154,133,28,201,76,121,42,188,2,183,246,40,154,249,177,77,158,25,140,162,231,101,151,159,80,63,54,229,204,96,150,101,176,81,166,174,25,117,219,97,112,143,218,144,84,94,3,218,96,58,125,65,103,115,248,166,101,196,106,112,119,56,143,45,86,35,169,120,187,15,63,210,77,230,95,159,208,20,216,183,211,82,64,133,36,238,192,128,24,53,24,86,189,107,132,232,27,248,128,122,62,75,194,224,161,120,196,154,249,146,1,213,239,161,194,35,35,64,15,184,71,213,136,163,141,150,135,187,30,254,7,93,106,41,55,59,67,100,81,83,111,195,129,109,34,241,207,120,219,55,116,48,181,133,39,94,33,138,167,75,137,215,243,123,180,90,249,69,69,193,168,239,183,151,232,39,249,204,162,243,212,91,26,249,73,122,26,23,169,56,85,146,131,179,119,214,202,204,195,122,46,49,110,173,39,230,21,36,231,230,222,88,1,35,196,80,104,116,146,78,111,202,242,252,64,79,246,236,191,195,78,71,118,23,174,108,152,78,135,126,102,63,255,0,248,192,53,163,43,5,0,0 };
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

