namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SspOperationExtensionsSchema

	/// <exclude/>
	public class SspOperationExtensionsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SspOperationExtensionsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SspOperationExtensionsSchema(SspOperationExtensionsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("63085386-1dd0-42f1-b47d-9c7bcf45cfbd");
			Name = "SspOperationExtensions";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("7cc31540-fa76-4c79-9b86-a6eabd8e662c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,147,193,110,219,48,12,134,207,46,208,119,224,188,139,3,20,242,125,77,2,172,105,182,203,134,21,240,246,0,140,66,219,66,109,201,16,229,38,89,219,119,159,36,59,70,146,174,195,124,16,44,146,250,249,81,164,52,182,196,29,74,130,159,100,45,178,41,157,88,25,93,170,170,183,232,148,209,162,40,30,174,175,158,175,175,146,158,149,174,160,56,176,163,86,20,36,123,171,220,225,118,114,156,158,111,91,163,255,238,177,244,158,93,220,223,121,151,119,126,180,84,249,196,176,106,144,249,19,20,220,253,232,104,128,89,239,29,105,246,63,28,35,243,60,135,57,247,109,139,246,176,28,247,241,20,148,198,194,206,216,199,144,102,167,92,13,248,132,170,193,77,67,96,142,98,12,62,9,115,39,142,74,249,137,84,215,111,26,37,129,157,15,149,32,163,232,123,36,201,115,164,121,131,51,240,212,36,31,25,84,9,174,38,232,153,44,212,200,96,85,85,59,6,103,160,69,141,21,5,144,232,101,49,73,229,151,90,243,14,45,182,160,125,207,22,41,143,29,88,235,74,105,74,151,199,142,0,69,131,39,33,2,105,169,92,164,247,119,197,121,112,190,156,231,81,43,74,159,215,250,100,212,118,160,94,161,254,30,225,124,225,191,2,90,230,106,197,112,169,6,231,36,51,8,195,146,36,27,99,26,144,168,63,111,91,165,21,59,127,111,4,139,139,96,241,149,156,79,179,222,123,171,163,233,118,179,116,202,29,19,167,51,120,121,137,170,201,255,159,63,77,252,96,172,195,102,212,186,141,74,190,35,217,135,11,190,35,123,226,106,107,118,160,105,7,83,173,123,73,93,212,246,161,126,172,196,23,99,91,116,89,136,249,102,36,54,234,119,24,175,34,58,179,244,124,182,211,155,65,54,121,211,10,49,233,138,85,111,45,105,23,32,61,189,54,110,172,42,2,78,165,165,179,27,248,103,117,99,121,175,97,13,203,235,240,168,72,111,135,119,21,182,222,22,190,63,251,52,209,41,253,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("63085386-1dd0-42f1-b47d-9c7bcf45cfbd"));
		}

		#endregion

	}

	#endregion

}

