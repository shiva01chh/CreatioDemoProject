namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: GetThrottlingScheduleRequestSchema

	/// <exclude/>
	public class GetThrottlingScheduleRequestSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public GetThrottlingScheduleRequestSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public GetThrottlingScheduleRequestSchema(GetThrottlingScheduleRequestSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("164861d9-449c-4213-a157-80657f43f33a");
			Name = "GetThrottlingScheduleRequest";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5f5fe385-d25b-4c17-9585-cfaff007abaf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,145,63,79,195,48,16,197,231,86,234,119,56,149,5,150,100,111,129,129,20,161,14,69,85,210,13,33,228,58,151,212,82,98,23,223,25,169,84,124,119,28,231,15,41,67,179,88,126,126,239,249,126,142,22,53,210,81,72,132,29,90,43,200,20,28,37,70,23,170,116,86,176,50,58,74,158,179,212,91,140,38,164,217,244,60,155,78,28,41,93,66,118,34,198,58,74,157,102,85,99,148,161,85,162,82,223,33,180,28,92,87,90,55,38,199,138,188,213,155,111,44,150,94,134,164,18,68,11,120,65,222,29,172,97,174,124,71,38,15,152,187,10,83,252,116,72,28,252,113,28,195,61,185,186,22,246,244,216,237,87,130,5,72,163,217,10,201,192,6,74,244,203,80,3,212,245,80,212,23,196,163,134,183,38,158,116,233,119,47,28,221,190,82,18,100,51,209,213,129,96,1,79,130,208,63,192,151,146,127,83,78,206,97,210,1,109,107,205,17,45,43,244,124,219,208,221,158,255,71,9,130,191,143,192,88,160,102,93,175,192,20,23,36,126,72,198,242,20,13,249,49,73,139,178,193,122,143,246,246,213,255,95,120,128,121,31,249,80,249,252,174,193,235,249,148,102,200,186,195,117,14,231,230,213,150,205,189,75,248,233,0,80,231,45,67,216,183,234,165,24,180,241,247,11,83,243,193,134,87,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("164861d9-449c-4213-a157-80657f43f33a"));
		}

		#endregion

	}

	#endregion

}

