﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DCReplicaModelSchema

	/// <exclude/>
	public class DCReplicaModelSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DCReplicaModelSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DCReplicaModelSchema(DCReplicaModelSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("eb4f0b98-3e23-4d31-a310-9250a56f1ae8");
			Name = "DCReplicaModel";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("748ec229-6875-456a-9dfd-63087e63e63a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,84,203,110,219,48,16,60,59,64,254,97,235,28,98,3,133,212,115,28,185,104,109,160,48,208,180,65,235,158,138,28,104,114,101,177,145,72,133,164,226,24,70,254,189,124,72,178,229,164,174,218,28,34,115,31,179,179,228,236,10,82,160,46,9,69,88,162,82,68,203,212,68,51,41,82,190,174,20,49,92,138,104,190,21,164,224,212,26,13,10,19,221,72,134,185,62,63,219,157,159,13,42,205,197,26,190,111,181,193,98,114,116,142,62,115,241,176,55,246,68,159,19,67,220,111,69,168,177,201,54,253,66,225,218,6,194,44,39,90,95,193,124,246,13,203,156,83,226,121,248,136,56,142,225,90,87,69,65,212,118,90,159,125,52,24,9,10,75,133,218,66,3,179,208,80,184,44,72,165,178,25,136,64,21,166,201,176,197,28,198,83,176,161,220,108,163,6,55,62,0,46,171,149,141,2,234,177,143,137,12,118,158,76,203,247,86,201,18,149,225,104,73,223,250,196,224,63,102,235,13,63,4,127,168,16,56,115,213,83,142,42,106,67,15,9,52,12,62,85,156,193,130,193,14,214,104,38,160,221,191,103,72,188,61,250,130,27,247,29,141,39,39,10,214,220,47,53,80,82,250,135,56,89,80,27,229,30,113,22,98,187,117,255,165,45,144,41,88,109,148,57,49,120,112,211,127,233,116,62,91,214,57,199,61,247,168,45,24,62,65,65,244,61,108,184,201,184,0,147,225,158,3,209,176,226,102,195,53,130,5,112,244,86,185,164,247,33,13,181,87,10,173,148,114,2,82,225,206,78,19,230,54,240,198,85,235,203,179,86,126,167,82,75,175,87,201,230,113,106,160,190,133,63,216,129,220,182,29,235,203,182,103,147,17,3,68,185,187,163,121,197,144,253,215,45,252,188,131,143,14,120,81,163,30,107,85,224,198,135,189,187,171,117,122,129,130,133,217,233,14,210,13,154,76,178,62,83,244,245,209,46,25,43,54,13,248,228,72,114,3,84,138,71,55,133,246,126,236,50,120,109,230,155,109,227,102,223,108,75,140,14,30,198,165,106,16,85,158,187,108,247,253,67,219,222,82,18,69,10,176,235,12,147,161,223,51,195,105,93,163,94,59,114,245,11,169,129,77,198,105,214,48,67,22,93,199,62,179,251,164,118,59,210,125,27,110,149,16,99,95,225,5,237,81,119,15,133,74,99,72,60,218,32,212,125,147,120,238,222,50,120,239,111,254,5,14,236,130,123,96,71,44,9,40,209,130,189,173,141,94,209,141,217,29,26,71,35,186,198,87,159,91,119,189,48,90,119,56,55,238,142,64,154,152,67,99,180,148,94,166,163,113,200,120,14,159,43,223,207,235,186,9,146,239,26,189,205,253,253,6,245,89,220,126,238,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("eb4f0b98-3e23-4d31-a310-9250a56f1ae8"));
		}

		#endregion

	}

	#endregion

}

