﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CaseTermIntervalSelectorSchema

	/// <exclude/>
	public class CaseTermIntervalSelectorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CaseTermIntervalSelectorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CaseTermIntervalSelectorSchema(CaseTermIntervalSelectorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("cda0dd91-7b53-42bf-ab60-415b9b107ffe");
			Name = "CaseTermIntervalSelector";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f69a32ba-7e77-47bd-be6b-d095bbdc629a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,221,86,219,110,211,64,16,125,54,18,255,176,45,18,114,164,202,121,167,77,16,10,42,84,80,110,41,79,8,161,173,51,113,23,214,235,176,151,160,0,249,119,102,111,190,197,73,35,94,144,104,31,178,30,159,157,57,51,103,102,215,130,150,160,86,52,7,114,3,82,82,85,45,117,54,171,196,146,21,70,82,205,42,241,240,193,175,135,15,18,163,152,40,58,16,9,231,123,236,217,37,205,117,37,25,168,6,49,223,40,13,37,190,230,28,114,235,86,101,47,64,128,100,57,98,236,127,242,72,66,129,118,50,227,84,169,39,100,70,21,160,219,242,74,104,144,107,202,231,96,55,86,210,97,199,227,49,185,80,166,44,169,220,76,195,243,51,146,219,157,68,223,81,77,148,67,43,66,137,210,152,6,20,27,66,197,130,20,128,182,188,146,18,83,174,196,194,18,67,239,37,97,33,72,22,125,143,91,206,63,189,93,99,122,108,1,159,241,97,101,110,57,203,67,168,125,28,201,19,114,53,100,191,136,27,230,26,57,41,235,252,151,203,167,78,254,146,1,95,96,246,239,36,91,35,196,191,92,249,7,34,129,46,42,193,55,182,220,229,140,242,220,112,167,208,235,170,152,163,119,32,95,242,93,227,121,8,0,98,225,99,116,3,190,147,213,10,164,70,173,48,168,203,205,191,239,87,216,25,62,42,144,88,62,33,188,132,89,13,108,151,43,150,200,130,103,53,182,255,104,123,42,73,80,143,115,183,136,41,170,96,216,30,102,141,142,80,87,99,107,218,227,29,130,239,83,38,29,249,200,219,227,208,61,210,166,243,24,92,37,61,208,164,7,243,9,14,73,131,208,61,74,94,9,166,25,229,236,39,72,28,19,237,108,105,47,250,49,117,186,6,125,87,45,142,145,214,35,253,240,72,208,70,10,156,36,86,66,61,26,100,137,125,221,74,98,88,123,103,89,81,73,75,34,240,96,153,156,82,89,152,18,132,86,167,211,103,113,233,92,133,185,196,198,203,46,198,110,71,227,32,16,152,222,180,9,32,44,218,91,210,173,153,212,6,217,117,230,173,63,103,4,107,152,62,103,174,110,200,244,2,99,227,232,159,145,234,246,43,22,115,74,106,146,81,210,126,67,96,73,148,225,26,5,19,240,99,167,93,82,175,69,178,166,117,90,155,247,6,140,21,216,157,102,254,60,220,88,41,91,212,90,192,105,234,28,36,206,123,211,219,177,98,233,105,87,251,211,179,222,56,141,6,24,92,83,65,11,156,215,35,56,4,232,180,157,136,59,225,222,160,134,232,160,147,84,246,28,190,219,223,54,120,37,97,9,146,222,114,184,228,180,80,54,102,71,1,123,163,104,202,132,250,0,170,226,107,32,191,15,0,240,100,86,224,125,255,184,99,28,72,218,112,57,65,5,12,231,228,241,99,114,226,53,177,9,93,83,245,45,29,101,47,169,178,225,211,30,155,81,84,181,83,158,86,90,33,125,235,233,10,47,169,38,220,89,211,25,59,21,247,4,147,110,26,36,55,120,183,8,71,8,3,244,25,134,61,90,110,34,163,221,78,115,247,81,195,205,110,238,244,90,43,66,244,215,39,97,93,4,6,118,185,19,63,97,75,146,158,180,28,213,149,59,172,218,40,108,79,18,44,127,12,114,236,222,90,4,31,126,240,60,108,212,173,35,13,225,178,214,137,105,35,190,98,120,181,79,238,235,185,22,129,97,175,254,212,135,197,188,238,144,26,127,47,141,184,231,131,225,24,249,18,9,165,12,91,137,76,166,196,254,102,241,253,172,153,170,73,51,98,181,48,123,2,217,115,240,198,247,133,19,52,100,100,77,217,27,132,226,50,34,158,62,221,129,212,206,183,113,17,250,178,133,25,240,28,183,109,255,190,105,220,36,255,109,215,248,205,255,180,109,60,133,255,170,111,92,74,247,52,78,141,57,212,57,53,104,200,121,175,119,182,248,225,160,243,187,186,144,71,223,45,8,69,53,152,48,225,62,136,14,143,118,224,241,254,187,33,28,199,7,190,155,188,181,107,68,27,254,253,1,147,93,55,14,38,13,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("cda0dd91-7b53-42bf-ab60-415b9b107ffe"));
		}

		#endregion

	}

	#endregion

}

