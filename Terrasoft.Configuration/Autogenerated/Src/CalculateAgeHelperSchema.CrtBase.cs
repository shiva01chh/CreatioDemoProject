namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CalculateAgeHelperSchema

	/// <exclude/>
	public class CalculateAgeHelperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CalculateAgeHelperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CalculateAgeHelperSchema(CalculateAgeHelperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7036e87b-0dda-4a95-ba07-111b121eb842");
			Name = "CalculateAgeHelper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("1fca9dd8-7af0-4ded-b1a3-aead7ca3b750");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,197,84,77,111,19,49,16,61,39,82,254,195,144,74,85,114,200,46,92,219,52,168,10,80,56,180,66,162,32,113,116,189,179,91,11,175,189,248,35,40,66,253,239,140,237,253,34,77,41,23,196,30,86,235,241,123,51,207,51,207,171,88,141,182,97,28,225,22,141,97,86,151,46,219,106,85,138,202,27,230,132,86,179,233,207,217,116,226,173,80,21,124,218,91,135,245,249,108,74,145,19,131,21,109,3,108,37,179,246,12,182,76,114,47,153,195,203,10,223,163,108,208,68,88,158,231,176,182,190,174,153,217,111,218,117,100,64,169,13,240,142,4,92,43,199,184,3,86,97,6,208,17,243,17,179,241,119,82,112,224,145,124,172,218,36,8,237,117,93,163,187,215,5,9,251,104,196,142,128,81,205,35,57,73,207,61,242,111,80,4,25,74,59,168,12,210,39,137,243,198,160,114,113,35,235,201,249,33,123,221,48,195,106,80,212,200,139,185,80,141,119,111,136,48,223,100,235,60,238,12,64,131,206,27,101,55,206,120,132,21,136,50,213,220,49,41,138,117,222,237,6,120,147,52,195,157,214,18,62,216,27,237,174,146,168,109,210,20,42,44,194,235,86,212,8,125,209,37,196,22,76,82,170,33,158,133,23,172,47,160,163,100,159,29,191,209,63,98,252,60,80,30,254,190,61,248,221,51,9,243,107,161,190,48,233,113,158,193,255,238,205,219,160,168,211,243,124,91,94,12,125,137,76,219,83,178,46,201,114,220,148,19,84,69,50,85,187,110,29,70,215,196,146,92,238,180,9,54,139,246,76,136,214,170,143,77,186,104,165,60,147,121,240,238,40,233,209,217,92,161,131,210,75,9,123,100,134,238,148,209,245,191,243,45,29,227,96,20,233,156,59,97,92,240,132,160,162,36,232,29,233,33,232,215,160,232,15,211,160,17,47,158,178,246,8,124,122,122,108,200,3,160,75,55,233,43,241,33,17,140,44,255,155,223,169,188,138,63,27,66,140,240,89,16,29,236,215,59,36,4,90,70,107,159,49,252,178,40,210,49,87,148,106,217,94,179,195,123,247,26,22,161,208,10,94,45,225,44,212,76,249,30,198,158,124,249,148,225,34,108,28,160,245,248,249,5,190,97,31,118,192,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7036e87b-0dda-4a95-ba07-111b121eb842"));
		}

		#endregion

	}

	#endregion

}

