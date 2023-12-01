﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DCStrategyResolverRuleSchema

	/// <exclude/>
	public class DCStrategyResolverRuleSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DCStrategyResolverRuleSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DCStrategyResolverRuleSchema(DCStrategyResolverRuleSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("cdad65ac-937a-4402-a670-9783b348787f");
			Name = "DCStrategyResolverRule";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("41c9b305-ccaa-4408-abc9-8158dd3fa84a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,213,86,205,111,218,48,20,63,83,169,255,195,19,189,80,105,10,247,81,168,58,90,77,59,180,171,58,166,29,39,227,188,128,181,196,142,108,167,45,171,250,191,239,217,113,8,73,3,77,183,29,54,46,192,243,251,189,239,47,201,50,52,57,227,8,11,212,154,25,149,216,104,174,100,34,86,133,102,86,40,25,93,110,36,203,4,39,162,69,105,143,143,158,142,143,6,133,17,114,213,64,100,153,146,147,206,151,253,178,162,107,21,99,106,8,70,192,19,141,43,98,129,121,202,140,121,15,151,243,47,150,64,184,218,220,161,81,233,61,234,187,34,69,207,57,30,143,225,204,20,89,198,244,102,22,254,127,96,6,129,59,40,36,74,3,3,190,102,66,130,74,64,19,204,68,240,201,64,105,154,85,96,114,228,34,217,0,147,32,164,177,76,146,247,196,73,32,37,185,70,139,96,112,149,145,129,222,104,48,193,144,168,210,61,222,81,158,23,203,84,112,96,75,199,197,109,176,97,159,245,131,39,239,65,237,172,34,253,186,224,86,105,242,249,214,203,42,57,218,78,122,194,14,187,243,35,215,152,51,141,64,42,109,112,88,82,68,225,65,216,181,42,44,57,36,241,209,250,8,192,146,254,59,58,196,152,176,34,181,181,14,164,192,105,76,166,67,50,122,199,237,202,1,23,217,225,120,182,141,84,180,69,142,219,230,157,145,53,44,3,74,49,78,135,220,229,248,209,14,103,23,205,40,239,85,56,15,0,210,229,131,24,157,141,189,188,110,241,193,141,202,202,225,236,155,72,83,88,34,80,254,10,45,49,6,145,80,52,182,201,11,73,23,24,191,144,235,101,227,35,199,220,167,187,180,237,66,175,10,103,218,77,145,166,159,245,85,150,219,205,85,197,50,156,45,214,90,61,72,120,88,163,12,102,17,168,229,184,139,153,1,73,120,210,184,21,239,181,134,162,233,174,146,81,103,88,32,136,125,7,251,211,4,173,160,156,130,235,213,193,32,64,163,249,26,249,143,93,199,70,206,98,149,140,2,195,233,233,196,243,87,42,167,149,210,146,124,217,148,78,207,45,125,158,237,249,237,245,155,97,44,138,172,93,193,96,215,88,23,240,63,82,118,206,30,151,164,186,222,114,173,56,26,243,150,130,251,191,138,173,3,5,85,24,254,114,133,221,4,177,68,175,52,236,214,212,9,202,184,28,156,205,41,122,171,85,142,218,10,116,51,84,43,139,220,98,124,160,12,127,187,52,186,107,48,175,84,66,119,48,171,239,39,88,161,157,192,161,6,57,104,89,71,34,156,105,118,205,220,104,239,93,141,61,156,232,74,249,54,55,61,220,152,23,90,83,20,90,219,53,76,139,198,62,125,67,56,27,147,174,61,139,154,70,245,42,148,215,150,237,5,237,213,159,155,253,249,88,96,150,167,164,253,14,115,101,4,141,180,205,211,226,249,245,90,17,247,132,129,46,248,89,77,244,135,209,12,190,219,23,76,147,70,75,247,17,242,146,39,52,45,69,12,166,157,74,224,252,220,115,12,70,93,143,174,57,31,250,41,31,133,218,143,190,26,212,244,91,82,98,41,17,213,24,48,251,45,152,194,61,75,139,94,237,127,141,116,238,196,61,239,167,242,190,19,164,15,235,11,207,151,167,63,147,202,227,113,219,53,218,119,0,157,141,135,214,79,121,113,152,222,27,167,125,89,145,202,29,94,55,195,137,74,99,188,146,187,147,241,237,153,121,160,53,62,226,182,45,46,242,156,80,108,153,226,66,249,105,127,58,57,16,29,234,41,33,209,116,31,191,192,56,87,58,14,23,52,171,230,9,127,117,57,255,97,116,186,227,112,192,253,47,229,113,223,245,62,170,214,213,61,211,181,99,211,87,35,70,8,154,166,163,26,49,245,155,182,146,230,31,235,213,213,122,28,148,230,183,39,86,41,214,149,246,14,79,37,36,58,232,68,9,45,145,1,104,58,46,176,86,187,148,212,38,209,211,232,243,11,56,126,72,244,5,14,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("cdad65ac-937a-4402-a670-9783b348787f"));
		}

		#endregion

	}

	#endregion

}

