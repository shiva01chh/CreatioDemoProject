﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TransactionEnricherSchema

	/// <exclude/>
	public class TransactionEnricherSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TransactionEnricherSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TransactionEnricherSchema(TransactionEnricherSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("04c524e2-811d-4113-a8c9-6aa0f6fbff0f");
			Name = "TransactionEnricher";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("93e06cc5-eabd-4f73-bbbe-f0e6647a43ae");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,84,219,78,219,64,16,125,78,36,254,97,234,246,193,145,144,243,94,146,60,208,36,40,82,169,40,161,229,17,45,246,132,172,106,175,221,189,64,83,196,191,119,118,55,142,47,108,40,8,97,118,246,204,245,156,89,193,10,84,21,75,17,110,80,74,166,202,141,78,190,148,98,195,31,140,100,154,151,226,100,248,124,50,28,24,197,197,3,172,119,74,99,113,214,59,19,62,207,49,181,96,245,214,93,114,129,2,37,79,95,97,230,76,179,198,216,174,163,40,74,17,190,105,85,24,6,72,60,102,79,230,231,71,175,22,66,115,205,81,29,5,44,89,170,75,233,17,132,25,143,199,48,81,166,40,152,220,205,246,103,27,35,221,162,130,171,235,203,27,201,132,98,174,127,64,27,123,151,212,94,227,150,91,101,238,115,158,66,154,51,165,160,229,179,16,210,134,146,4,121,118,249,6,31,37,62,216,96,75,142,121,166,62,195,149,228,143,76,163,191,172,252,1,126,40,148,52,34,225,7,15,119,166,115,62,107,67,37,178,172,20,249,14,148,150,182,221,187,141,17,217,215,178,252,101,170,53,101,46,216,55,18,8,76,33,90,146,61,122,219,181,98,82,19,195,106,203,43,162,221,20,162,246,189,106,46,86,46,136,235,4,69,230,155,233,118,70,133,82,64,99,199,108,251,115,147,241,136,254,176,157,97,37,136,48,150,243,191,8,2,159,128,147,51,19,36,231,114,67,88,68,72,37,110,166,81,96,166,209,120,150,28,162,142,251,97,39,212,12,43,64,80,7,211,168,59,191,104,102,231,11,233,193,144,76,198,14,237,156,247,84,6,18,198,61,90,186,81,71,96,247,108,48,232,145,69,227,11,176,247,242,214,0,47,81,111,203,163,218,184,48,60,131,11,212,45,78,150,178,44,44,189,177,187,171,164,59,172,178,186,34,111,109,83,72,69,89,99,178,40,42,189,115,5,13,214,104,215,28,148,251,124,55,40,119,4,178,132,248,139,184,215,214,200,57,249,159,196,139,37,14,235,167,131,180,149,198,65,137,118,96,183,52,109,140,35,210,218,40,89,169,197,111,195,242,216,71,76,156,186,226,166,199,17,48,181,175,209,55,226,183,62,158,159,47,254,96,106,72,132,144,221,31,254,157,246,119,137,30,12,101,36,206,207,27,83,60,170,7,87,199,90,217,7,238,154,182,133,84,35,253,103,218,158,84,226,227,163,135,196,77,190,38,210,224,105,203,115,132,216,187,39,22,217,202,67,236,246,232,217,227,136,103,223,247,79,150,27,156,88,210,102,199,230,124,182,143,245,226,191,254,227,255,74,212,70,138,174,6,106,29,190,79,137,255,219,98,191,35,253,23,243,137,107,178,53,89,223,187,175,68,111,103,255,236,187,27,205,40,56,232,87,239,241,41,208,104,41,53,87,180,209,165,229,16,51,159,216,202,44,180,218,143,92,106,82,20,60,150,180,23,190,240,86,182,91,114,109,149,28,251,236,16,42,169,187,96,181,36,137,189,16,216,114,121,179,171,48,123,77,232,167,232,57,184,19,47,118,1,60,173,124,3,141,232,225,67,123,127,15,42,10,239,121,248,165,104,22,104,47,27,151,160,227,27,78,50,8,246,182,238,232,244,136,66,79,187,197,213,153,91,66,13,203,145,172,244,59,28,254,3,215,162,67,164,235,8,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("04c524e2-811d-4113-a8c9-6aa0f6fbff0f"));
		}

		#endregion

	}

	#endregion

}

