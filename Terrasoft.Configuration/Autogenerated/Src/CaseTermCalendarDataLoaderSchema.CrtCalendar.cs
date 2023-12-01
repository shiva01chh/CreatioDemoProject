﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CaseTermCalendarDataLoaderSchema

	/// <exclude/>
	public class CaseTermCalendarDataLoaderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CaseTermCalendarDataLoaderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CaseTermCalendarDataLoaderSchema(CaseTermCalendarDataLoaderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9712020e-c367-4924-926b-027b2ee7f27d");
			Name = "CaseTermCalendarDataLoader";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("28322dfd-15f8-434e-b343-12da0b1a75f6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,205,85,75,111,211,64,16,62,167,82,255,195,200,92,28,41,178,239,109,18,9,210,80,69,162,8,104,202,129,11,90,236,113,186,146,189,107,246,81,100,42,254,59,179,126,196,143,36,78,196,137,28,154,238,236,124,243,248,190,153,141,96,25,234,156,69,8,91,84,138,105,153,152,96,37,69,194,119,86,49,195,165,184,190,122,189,190,154,88,205,197,14,30,11,109,48,187,221,159,187,144,44,147,226,248,141,194,83,246,224,238,221,201,171,181,48,220,112,212,228,64,46,111,20,238,168,24,216,8,131,42,161,114,111,96,67,128,108,197,210,200,166,101,161,244,47,138,152,169,59,102,216,7,201,98,84,37,50,12,67,152,107,155,101,76,21,203,250,188,143,2,137,84,16,213,64,136,9,9,105,9,13,26,100,216,129,230,246,71,202,35,224,123,244,37,37,76,94,203,50,14,234,40,13,206,73,247,11,8,246,206,225,208,123,158,51,197,50,16,36,217,194,107,64,155,216,91,54,121,129,199,72,180,37,156,26,152,135,165,119,11,86,104,172,18,186,117,46,179,205,195,198,238,28,71,250,129,123,52,221,179,127,111,121,12,109,21,83,167,228,159,74,44,50,85,122,245,180,91,165,76,235,27,248,119,217,190,96,174,80,83,135,186,86,233,80,190,49,221,34,151,255,124,122,184,108,180,26,93,155,238,222,115,76,99,106,239,147,226,47,204,96,117,153,87,7,80,200,98,41,210,2,158,52,42,90,47,129,145,139,11,223,109,239,124,91,135,236,243,215,18,40,133,54,202,70,70,42,151,168,236,106,100,184,54,130,22,136,165,252,55,106,16,248,139,230,86,27,38,104,108,101,66,206,136,16,41,76,22,222,217,94,189,112,121,225,76,246,187,241,150,174,91,136,246,134,222,76,214,162,156,205,238,15,40,235,231,152,130,123,157,38,147,1,145,176,128,3,102,39,245,116,158,164,247,1,205,179,140,47,97,246,127,91,219,243,92,158,221,222,154,71,158,128,223,90,97,177,0,231,24,172,179,220,20,141,207,164,74,13,194,166,105,201,171,35,150,254,190,176,118,25,215,250,39,105,224,166,174,124,199,139,199,232,25,51,246,217,162,42,252,129,86,65,215,227,129,9,182,67,53,3,175,169,214,155,222,30,68,255,72,84,82,248,78,178,224,109,28,175,100,106,51,225,123,238,214,155,6,238,171,133,26,158,225,55,41,112,28,186,173,189,130,163,49,246,130,247,241,68,109,213,194,176,179,217,240,121,108,169,35,98,198,212,170,137,94,29,239,215,101,220,22,57,214,101,127,101,169,197,57,189,12,244,43,186,244,187,28,77,103,85,156,237,241,230,71,227,116,9,155,86,42,143,44,209,177,135,159,108,244,249,11,71,139,150,71,97,8,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9712020e-c367-4924-926b-027b2ee7f27d"));
		}

		#endregion

	}

	#endregion

}
