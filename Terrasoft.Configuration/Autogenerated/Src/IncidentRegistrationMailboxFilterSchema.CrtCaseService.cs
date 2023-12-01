﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IncidentRegistrationMailboxFilterSchema

	/// <exclude/>
	public class IncidentRegistrationMailboxFilterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IncidentRegistrationMailboxFilterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IncidentRegistrationMailboxFilterSchema(IncidentRegistrationMailboxFilterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("84c2d0e8-ccac-4adc-9ae6-3ff22fdf6ba5");
			Name = "IncidentRegistrationMailboxFilter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("42d0e60b-8c79-4301-a0b9-ee86b6242c08");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,189,87,75,111,27,55,16,62,43,64,254,3,171,28,186,2,22,235,156,35,91,128,163,216,129,138,56,118,45,183,57,4,62,208,171,145,68,116,151,148,73,174,19,213,240,127,239,240,181,79,105,45,7,70,125,50,103,57,51,223,60,248,205,136,211,28,212,134,166,64,110,64,74,170,196,82,39,83,193,151,108,85,72,170,153,224,111,223,60,190,125,51,40,20,227,43,50,223,42,13,249,184,117,198,251,89,6,169,185,172,146,207,192,65,178,180,115,231,11,227,247,149,176,238,43,207,5,223,253,69,194,62,121,114,198,53,211,12,20,94,192,43,239,36,172,208,59,153,102,84,169,15,100,198,83,182,0,174,175,81,170,180,11,227,130,178,236,78,252,60,103,153,6,137,42,71,71,71,228,88,21,121,78,229,118,226,207,238,35,73,51,134,202,36,119,26,160,136,67,160,138,205,70,200,154,60,9,102,142,106,118,54,197,93,198,82,180,129,72,44,16,254,28,18,147,222,42,2,204,161,166,92,99,20,87,146,61,80,13,54,192,193,198,29,72,106,190,19,52,101,16,157,98,206,31,152,222,206,211,53,228,244,43,86,146,156,144,97,144,14,199,123,21,3,4,33,119,165,170,105,174,255,110,143,147,107,72,97,99,51,137,86,202,67,143,194,84,108,182,13,165,134,160,71,241,99,134,89,238,104,119,165,61,38,206,76,85,207,165,200,77,184,31,197,207,249,150,167,115,208,26,191,169,90,22,234,226,100,14,88,91,105,53,79,23,11,9,74,245,56,56,205,24,85,254,154,173,82,237,60,116,93,60,120,135,6,93,31,248,179,111,138,43,41,54,32,77,187,99,87,216,254,114,223,219,61,108,5,159,152,125,137,40,138,13,2,77,25,87,248,79,86,228,156,112,83,83,170,200,63,176,37,148,47,130,152,26,44,70,254,64,179,2,146,210,116,189,175,67,99,87,230,143,93,100,177,143,112,130,33,26,59,83,107,243,130,110,136,109,236,193,10,244,152,132,148,40,60,24,233,83,79,0,127,41,243,6,5,231,142,82,250,225,152,203,211,242,110,251,88,67,208,242,188,47,213,246,253,201,34,213,66,30,146,236,25,71,22,194,244,253,139,44,65,9,135,31,132,217,247,139,116,42,150,68,175,1,85,0,59,65,194,242,100,248,60,27,12,143,38,142,57,250,131,126,222,80,52,242,177,183,107,114,98,65,238,47,98,52,122,182,62,255,115,204,86,178,161,146,230,182,125,79,134,69,163,198,195,201,13,122,44,90,61,115,124,100,53,94,152,180,86,247,52,29,141,108,62,63,96,128,76,149,233,109,105,156,180,116,14,233,184,11,208,107,177,216,199,247,15,130,45,8,210,68,89,193,200,78,62,79,249,127,22,32,183,4,212,125,76,102,103,188,200,65,210,187,12,142,195,131,116,207,91,5,176,75,28,156,52,93,147,200,83,146,127,253,140,183,47,182,187,230,187,251,126,139,241,161,175,164,132,19,57,249,40,49,179,194,198,106,130,45,35,14,49,116,17,127,6,125,166,238,113,164,56,97,0,164,236,233,160,88,30,168,52,88,124,63,119,60,180,74,153,212,47,92,80,78,87,32,99,239,206,53,252,160,145,99,155,209,224,209,125,151,160,11,201,141,207,241,142,16,29,202,239,183,54,50,51,16,148,175,19,161,126,26,187,99,128,239,3,150,144,50,59,153,172,14,6,211,188,141,203,148,190,217,110,192,35,251,219,176,115,72,72,212,174,81,57,229,110,61,226,80,229,244,21,140,55,198,104,203,193,221,171,120,232,78,235,224,198,150,218,230,20,61,56,245,228,15,193,120,52,28,15,227,86,10,227,16,110,92,194,106,213,207,26,74,174,168,84,80,159,220,209,40,185,17,167,184,98,110,155,12,184,171,192,97,193,186,14,174,149,47,249,231,2,31,107,200,193,108,209,237,213,118,223,119,23,184,216,244,51,186,121,44,211,16,55,247,162,120,199,182,243,228,99,220,217,114,254,209,26,215,246,220,122,26,113,29,240,24,141,212,179,85,117,115,171,141,119,165,136,225,218,133,10,61,203,55,96,189,11,174,163,50,153,193,42,150,67,51,76,166,89,124,67,214,216,146,68,187,190,39,51,245,181,200,178,75,92,188,54,24,205,168,36,45,143,249,125,141,136,122,82,127,232,10,28,19,103,221,208,204,247,219,199,254,69,49,20,194,36,220,205,20,149,124,17,43,150,210,236,18,55,56,234,135,68,91,52,199,124,164,58,185,148,93,109,108,79,195,70,201,20,169,91,131,147,126,99,122,125,101,198,27,152,43,145,19,226,239,40,28,121,76,9,110,158,92,114,118,95,208,44,118,208,251,32,199,187,107,176,35,142,215,64,82,95,122,251,61,187,62,171,126,88,98,119,245,180,85,187,199,43,189,86,183,55,201,160,215,102,98,123,245,101,19,252,185,117,17,1,42,178,180,89,130,69,32,181,31,152,68,81,232,242,247,165,167,168,3,183,33,119,123,56,113,239,148,104,65,238,160,116,209,216,131,172,170,139,92,77,206,155,32,240,98,248,82,91,153,60,193,35,234,146,234,190,57,176,229,50,21,70,183,51,243,60,227,253,194,179,51,108,216,251,236,226,230,143,171,167,218,220,200,127,181,67,202,161,243,5,193,25,229,189,115,99,220,220,173,130,87,196,104,54,171,18,64,73,83,97,215,233,252,120,68,47,238,198,192,235,191,104,126,246,37,40,76,210,224,219,254,222,123,61,215,245,236,151,174,12,125,255,214,13,114,47,123,15,202,108,39,215,144,139,7,136,42,193,183,53,182,106,132,40,39,68,57,62,81,81,215,116,104,153,193,96,110,129,86,60,132,204,186,96,156,102,179,21,199,50,77,169,130,209,8,121,77,42,125,41,63,193,146,22,153,142,2,241,248,193,225,240,119,18,245,106,240,59,150,95,21,253,83,157,229,58,43,83,133,172,92,121,14,249,213,183,192,153,165,1,129,234,53,13,44,69,176,239,75,26,37,178,246,148,9,149,128,63,251,65,153,15,248,16,2,217,87,11,219,193,20,87,45,40,195,73,216,152,136,245,200,150,12,100,15,201,97,166,113,47,89,30,4,150,255,174,119,225,221,205,140,119,66,100,100,166,174,220,253,58,133,57,30,158,241,0,116,223,82,88,237,64,89,86,45,146,142,49,247,46,152,245,85,205,45,73,173,64,220,61,59,185,156,169,3,182,177,6,128,96,23,187,127,175,221,19,242,190,189,116,45,77,166,199,221,222,211,178,128,158,17,234,164,117,33,74,240,239,63,147,45,100,95,149,22,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("84c2d0e8-ccac-4adc-9ae6-3ff22fdf6ba5"));
		}

		#endregion

	}

	#endregion

}

