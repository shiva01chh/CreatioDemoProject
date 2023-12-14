namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ISocialMentionExecutorSchema

	/// <exclude/>
	public class ISocialMentionExecutorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ISocialMentionExecutorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ISocialMentionExecutorSchema(ISocialMentionExecutorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("731044fc-827f-47a1-af08-e646f558fb9f");
			Name = "ISocialMentionExecutor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b66b5ae8-46e0-4931-ad78-c2c1ba5fd6ea");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,145,207,110,194,48,12,198,207,67,226,29,44,118,217,164,169,189,3,227,50,161,137,3,19,82,247,2,166,117,219,104,52,65,182,195,31,161,189,251,66,90,58,134,52,114,74,190,248,251,252,147,109,177,33,217,98,78,240,73,204,40,174,212,228,205,217,210,84,158,81,141,179,201,60,251,24,14,78,195,193,131,23,99,43,200,142,162,212,76,134,131,160,60,50,85,161,4,96,97,149,184,12,41,99,88,100,46,55,184,89,146,61,187,231,7,202,189,58,142,229,105,154,194,84,124,211,32,31,103,221,123,197,110,103,10,18,104,72,107,87,8,148,142,97,239,248,11,246,70,107,240,66,28,190,98,150,36,151,140,244,42,100,235,215,27,147,131,185,16,252,3,0,167,136,208,35,47,219,118,99,88,69,127,251,121,11,24,133,12,119,116,65,0,92,59,175,145,74,64,107,212,158,45,0,4,129,32,247,204,65,10,186,8,86,148,244,177,233,109,238,116,139,140,13,216,176,128,215,81,87,190,40,70,179,101,123,5,83,36,211,52,214,220,181,252,26,148,14,250,199,178,115,166,128,110,14,97,167,138,185,202,211,187,15,98,223,238,5,68,249,188,214,78,121,158,116,99,34,91,180,147,138,239,239,118,221,87,98,80,206,231,7,133,83,105,120,63,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("731044fc-827f-47a1-af08-e646f558fb9f"));
		}

		#endregion

	}

	#endregion

}

