﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DuplicatesRuleBodySchema

	/// <exclude/>
	public class DuplicatesRuleBodySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DuplicatesRuleBodySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DuplicatesRuleBodySchema(DuplicatesRuleBodySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("38fbb60e-82a4-4e98-a13b-4b74eaca3548");
			Name = "DuplicatesRuleBody";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4c53ad23-c903-414d-89cd-b08703861304");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,189,84,223,111,211,48,16,126,206,164,253,15,102,147,166,20,80,36,120,131,110,123,160,131,49,180,95,90,199,19,226,33,77,46,173,193,177,131,237,108,42,85,255,119,206,63,146,54,153,169,90,49,81,41,77,124,190,251,190,239,206,231,227,105,9,170,74,51,32,247,32,101,170,68,161,147,145,224,5,157,214,50,213,84,240,228,12,242,186,98,52,179,171,253,189,197,254,94,84,43,202,167,228,26,30,181,224,54,226,139,18,124,216,110,140,231,74,67,137,48,140,65,102,162,84,114,14,28,36,205,208,7,189,14,37,76,209,74,70,44,85,234,61,57,243,240,160,238,106,6,31,68,62,183,94,223,12,232,205,228,7,66,196,87,80,78,64,142,17,34,101,244,183,211,117,83,233,11,62,248,142,158,85,61,65,0,146,25,184,32,90,180,176,136,45,241,173,20,21,72,77,1,217,111,109,176,219,183,148,126,115,30,55,31,215,88,34,114,66,14,10,202,52,72,117,96,57,27,210,75,170,244,113,151,243,147,245,59,37,238,173,200,130,76,65,15,137,50,127,203,109,136,164,16,122,156,205,160,76,141,165,203,167,180,52,37,190,235,184,132,40,14,129,231,46,221,110,238,87,160,103,34,239,37,238,193,197,3,246,0,205,129,76,132,96,228,227,175,58,101,42,22,246,8,8,190,6,196,28,126,20,61,164,146,228,79,202,252,22,165,199,79,171,63,192,192,161,13,163,5,137,131,97,39,132,215,140,53,232,145,4,93,75,78,10,36,7,23,185,92,209,66,145,214,76,143,109,21,70,162,172,82,9,18,137,173,86,170,231,141,233,216,213,233,20,187,215,6,12,91,4,9,10,215,24,18,132,74,124,210,221,250,190,118,194,2,226,147,174,227,96,149,105,115,250,62,59,114,116,20,174,89,56,121,167,178,159,189,239,192,207,169,154,141,193,228,192,225,145,248,85,184,9,27,25,94,88,155,188,255,64,81,93,204,4,31,95,130,80,182,125,180,190,214,112,239,57,107,207,184,113,8,56,158,231,27,3,13,222,243,12,2,181,249,110,110,190,151,155,161,51,193,234,146,255,21,122,212,110,239,14,173,231,85,24,244,30,55,254,101,72,57,81,161,185,232,47,225,218,180,242,190,187,211,41,81,203,12,92,248,215,139,60,92,248,174,207,127,158,138,230,210,227,114,235,113,230,237,231,160,205,221,27,137,28,226,129,9,70,140,164,99,92,191,89,125,73,148,235,30,130,99,173,57,150,59,251,9,121,163,194,140,143,153,247,194,122,174,122,52,192,229,114,177,109,209,79,38,90,195,104,63,95,146,55,239,200,171,181,230,12,98,46,9,96,5,182,1,50,204,97,136,149,186,254,89,191,216,65,104,47,118,19,149,63,164,6,97,237,252,182,31,117,104,195,223,31,105,25,70,1,105,9,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("38fbb60e-82a4-4e98-a13b-4b74eaca3548"));
		}

		#endregion

	}

	#endregion

}
