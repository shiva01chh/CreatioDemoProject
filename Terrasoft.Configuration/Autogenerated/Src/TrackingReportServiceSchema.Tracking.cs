﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TrackingReportServiceSchema

	/// <exclude/>
	public class TrackingReportServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TrackingReportServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TrackingReportServiceSchema(TrackingReportServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4b5fb204-338d-431a-890a-e9af7ad86c56");
			Name = "TrackingReportService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("120fd877-7905-4e7f-9414-1956e0c20629");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,86,75,79,227,48,16,190,35,241,31,70,112,1,169,74,239,188,36,104,11,234,106,217,34,90,196,1,113,48,201,164,88,36,118,214,118,138,170,138,255,190,227,196,41,73,26,250,0,86,203,74,228,80,213,227,121,124,243,121,60,99,193,98,212,9,243,17,70,168,20,211,50,52,94,71,138,144,143,83,197,12,151,194,27,41,230,63,113,49,222,222,154,109,111,1,125,169,166,21,12,167,218,96,124,184,40,242,134,168,38,220,199,75,25,96,180,106,223,59,245,13,159,100,129,86,170,222,226,67,147,14,137,73,79,107,114,49,52,204,96,147,78,71,70,17,250,54,138,246,46,80,160,226,126,69,237,53,119,235,173,35,227,56,195,147,171,236,42,28,147,37,116,34,166,245,1,20,124,92,99,34,149,113,8,11,221,118,187,13,71,58,141,99,166,166,39,175,162,204,20,140,132,103,169,158,224,153,155,71,80,153,57,232,220,222,43,153,183,171,246,119,46,4,157,138,161,208,230,222,137,79,117,242,11,13,97,77,136,190,7,30,113,51,189,198,223,41,87,24,163,48,122,175,188,176,4,194,49,172,48,177,90,158,19,4,251,46,78,146,62,68,220,7,63,203,160,49,119,56,128,51,166,209,173,90,208,191,70,22,12,68,52,45,159,74,238,108,86,240,212,192,107,111,66,24,206,17,3,139,0,181,41,171,54,208,90,136,157,54,116,71,3,8,165,130,49,26,13,62,113,69,84,65,72,238,188,154,155,246,162,159,74,142,139,56,10,181,217,235,223,50,254,43,37,19,84,134,35,37,113,149,121,42,67,95,2,127,94,29,14,45,15,40,50,15,57,170,44,147,231,71,169,209,230,83,79,99,89,42,165,116,46,82,30,64,143,60,154,105,63,128,153,245,116,72,245,70,63,47,27,2,28,132,33,217,129,12,169,106,51,78,48,200,48,209,210,151,42,208,155,99,211,70,217,123,231,28,127,4,91,71,166,226,83,161,113,114,151,59,93,10,107,23,69,144,23,64,121,167,162,214,172,242,118,217,235,132,250,19,174,89,247,93,234,38,202,153,124,122,225,23,72,10,189,191,85,249,229,194,250,231,149,116,254,161,178,233,247,68,26,163,98,15,17,30,149,152,180,222,78,114,106,245,7,235,156,78,150,11,13,52,170,232,180,105,106,107,54,70,106,18,40,192,158,66,54,67,33,21,58,245,125,218,11,211,40,154,82,57,196,73,132,230,61,221,195,241,218,179,209,46,93,176,181,47,68,33,219,224,58,92,162,121,148,65,99,33,45,237,254,38,85,162,90,247,16,42,25,67,194,20,61,109,12,42,189,198,61,184,27,20,12,214,166,108,182,73,111,130,190,152,200,39,220,203,65,210,36,221,185,26,12,71,59,45,184,81,124,132,196,49,77,56,43,189,176,211,53,67,98,79,159,246,207,100,48,29,154,105,100,119,201,141,35,114,46,245,110,21,75,18,12,90,85,42,221,228,57,151,42,102,166,98,153,139,188,31,90,138,22,20,247,116,185,222,254,253,194,125,95,184,233,80,5,190,87,159,129,25,175,238,255,126,189,27,76,152,2,180,6,93,102,24,181,132,9,205,49,69,104,4,62,231,145,202,242,189,27,122,241,80,40,145,63,199,246,15,215,240,229,144,117,237,101,98,70,190,233,123,232,63,98,204,230,106,181,80,173,69,199,239,138,62,231,236,120,181,174,87,227,181,68,163,87,76,230,218,217,219,175,172,150,55,182,86,69,150,141,167,58,120,149,93,133,87,102,154,59,185,253,102,139,17,43,215,124,141,196,10,199,94,217,176,33,19,215,150,55,241,232,18,110,192,152,55,209,141,208,101,38,85,87,47,135,181,254,180,81,163,137,232,109,251,5,186,204,79,130,241,255,181,152,2,245,119,127,249,196,254,50,39,245,187,185,124,193,230,82,44,22,31,63,243,237,234,22,137,183,182,254,0,68,19,22,86,150,17,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4b5fb204-338d-431a-890a-e9af7ad86c56"));
		}

		#endregion

	}

	#endregion

}

