﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DuplicatesScheduledSearchParameterEntityListenerSchema

	/// <exclude/>
	public class DuplicatesScheduledSearchParameterEntityListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DuplicatesScheduledSearchParameterEntityListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DuplicatesScheduledSearchParameterEntityListenerSchema(DuplicatesScheduledSearchParameterEntityListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0c4fa966-260a-42c6-97f5-2e5d7a12eadb");
			Name = "DuplicatesScheduledSearchParameterEntityListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4c53ad23-c903-414d-89cd-b08703861304");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,86,109,111,211,48,16,254,92,36,254,195,17,36,148,138,41,253,222,189,72,123,105,81,17,99,136,110,240,1,241,193,73,174,169,33,177,43,219,41,171,166,254,119,206,118,220,53,213,178,150,73,84,106,51,199,190,231,158,187,123,206,55,193,42,212,11,150,33,220,162,82,76,203,153,73,46,165,152,241,162,86,204,112,41,146,43,204,235,69,201,51,183,122,253,234,225,245,171,94,173,185,40,96,186,210,6,171,227,205,122,27,64,97,50,18,134,27,142,122,239,129,100,180,68,97,186,207,141,89,102,164,106,33,21,165,76,89,57,28,94,202,170,34,138,159,100,81,208,107,218,167,19,111,21,22,196,20,46,75,166,245,16,174,26,242,168,167,217,156,66,41,49,159,34,83,217,124,138,198,144,145,118,52,86,159,56,5,35,80,57,136,193,96,0,39,186,174,42,166,86,103,205,218,193,193,66,201,37,207,81,111,195,58,180,47,76,81,38,13,42,64,135,7,232,130,130,57,19,121,73,110,146,0,59,216,193,61,209,136,172,212,18,50,133,179,211,232,130,105,244,140,92,86,2,173,8,6,214,224,199,19,91,177,141,171,98,159,201,61,156,66,212,73,44,234,255,36,132,69,157,210,54,100,46,154,206,220,108,140,218,201,129,33,116,240,35,228,7,151,186,199,244,75,161,13,163,20,12,225,139,226,75,114,226,247,23,126,1,153,221,7,109,148,173,231,69,93,254,30,233,150,210,198,200,76,173,48,132,229,78,76,91,39,162,227,198,35,138,220,59,109,51,24,115,44,243,46,247,196,205,80,30,20,178,92,138,114,5,19,210,16,216,239,169,253,189,102,130,21,168,146,15,104,172,182,40,201,81,219,117,127,143,239,107,52,115,185,207,121,42,101,9,147,221,58,125,99,37,207,227,253,165,129,124,239,145,62,216,110,237,245,20,82,42,197,1,6,137,95,223,114,74,250,155,83,176,207,233,130,137,228,154,11,162,85,163,67,235,189,123,119,56,212,21,91,105,11,181,89,221,204,190,35,254,78,62,75,129,182,159,123,235,39,83,179,148,60,135,187,69,78,175,118,5,253,81,166,241,168,233,49,247,56,242,137,228,154,118,166,115,89,151,249,5,126,69,2,82,6,243,144,2,62,131,248,141,63,159,220,105,84,36,79,129,153,187,224,168,200,19,221,200,109,36,88,74,177,196,207,11,178,31,80,155,204,186,64,108,36,244,107,212,42,108,46,153,130,148,128,90,48,33,95,138,148,230,238,20,127,189,173,44,141,147,201,69,231,241,179,216,131,246,4,254,241,205,165,106,107,120,174,138,186,162,192,226,168,110,133,21,29,193,147,225,246,251,199,143,236,246,151,145,88,238,151,98,114,73,125,100,112,172,100,229,43,19,123,215,193,85,119,18,104,186,148,132,240,88,217,131,133,245,120,235,5,47,182,196,79,139,0,72,177,29,125,118,64,19,109,138,253,92,28,225,175,127,137,36,16,95,111,201,135,12,178,57,196,163,251,12,23,214,3,224,253,198,63,93,69,201,72,41,185,123,27,37,91,37,2,237,124,208,195,79,55,26,64,26,82,68,1,25,141,162,2,243,4,162,38,154,222,123,136,198,140,19,47,48,146,110,66,151,172,45,73,4,168,95,50,77,172,154,238,251,91,58,95,31,122,255,185,121,211,244,184,159,61,114,73,243,157,134,168,111,242,27,49,17,36,80,170,82,44,211,95,164,81,114,43,114,84,71,224,165,116,62,179,99,200,206,26,82,186,6,12,217,72,105,16,37,91,198,193,42,200,161,251,242,104,110,143,126,176,160,70,106,140,214,207,242,244,136,47,163,25,108,255,63,75,223,80,47,99,25,108,95,206,114,70,255,202,180,105,238,40,196,191,109,191,116,239,232,243,23,151,238,187,190,140,10,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0c4fa966-260a-42c6-97f5-2e5d7a12eadb"));
		}

		#endregion

	}

	#endregion

}
