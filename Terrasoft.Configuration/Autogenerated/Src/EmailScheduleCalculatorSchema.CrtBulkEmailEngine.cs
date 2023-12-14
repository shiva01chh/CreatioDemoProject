﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EmailScheduleCalculatorSchema

	/// <exclude/>
	public class EmailScheduleCalculatorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EmailScheduleCalculatorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EmailScheduleCalculatorSchema(EmailScheduleCalculatorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e54900c1-b29b-45b4-9d54-84bdf396c7ca");
			Name = "EmailScheduleCalculator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("7b5cce97-2e1e-4b17-90ca-f9813022e3eb");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,86,81,111,219,54,16,126,118,128,252,135,27,134,21,18,234,42,219,83,129,164,78,144,57,233,16,44,109,218,58,69,129,13,195,192,72,148,67,76,166,60,146,74,227,165,249,239,187,147,40,137,164,228,36,141,1,219,210,241,238,187,187,143,199,59,74,182,226,122,205,82,14,151,92,41,166,203,220,36,243,82,230,98,89,41,102,68,41,119,119,238,118,119,0,63,149,22,114,9,139,141,54,124,117,48,20,37,231,66,254,139,242,73,35,252,88,49,101,254,243,244,92,7,138,135,16,39,108,115,145,127,225,252,31,152,181,136,157,8,117,27,237,31,21,95,98,76,48,47,152,214,251,112,186,98,162,88,164,215,60,171,10,62,103,69,90,21,204,148,138,180,39,123,123,123,240,70,87,171,21,83,155,67,251,254,65,149,55,34,227,26,86,220,92,151,25,152,18,82,107,197,33,23,74,27,208,22,45,131,130,85,50,189,134,140,214,152,68,101,177,226,80,230,192,201,105,210,122,216,115,92,172,171,171,66,164,144,82,112,219,99,163,60,238,218,132,70,146,122,207,49,249,204,85,88,43,113,67,81,52,192,243,74,155,114,53,87,165,60,189,93,43,174,53,217,238,131,47,232,141,61,87,174,187,183,130,23,25,250,251,208,160,135,106,173,83,119,107,254,252,11,254,206,152,35,208,7,3,116,46,179,198,193,54,191,88,93,218,168,42,69,50,200,123,205,217,192,121,195,228,88,170,17,26,83,201,164,158,52,246,237,233,179,15,87,76,243,40,208,131,59,184,255,254,152,177,112,214,92,25,193,31,139,56,96,11,159,117,91,213,135,33,119,112,116,4,81,40,155,193,111,220,244,102,81,28,63,131,226,119,117,121,127,247,222,6,158,225,110,72,170,226,166,82,18,178,78,45,89,240,130,167,38,186,165,4,35,23,48,70,217,43,248,37,142,147,203,242,24,79,254,38,138,15,124,192,39,110,132,167,54,174,242,148,196,219,164,79,240,231,146,206,50,166,251,150,206,60,9,46,242,246,168,70,221,58,150,76,85,152,246,117,26,178,213,115,48,96,234,134,41,90,238,250,153,143,228,245,181,208,44,111,34,218,244,1,161,189,67,247,59,33,7,60,10,105,106,149,121,89,73,67,45,120,50,17,57,68,35,80,135,125,88,117,208,168,57,233,44,209,209,136,201,171,222,164,129,190,7,94,104,222,90,83,204,146,223,146,145,31,104,77,237,133,58,225,57,195,220,155,250,184,245,2,104,224,38,189,117,247,52,243,184,78,22,149,68,43,56,26,240,128,103,220,218,28,12,115,137,94,195,75,136,90,76,39,141,56,134,159,224,181,77,166,254,181,85,29,108,211,113,150,209,113,136,58,80,151,247,251,199,74,139,254,191,8,115,77,255,127,148,18,43,44,215,220,180,221,203,88,233,89,54,237,173,42,147,182,207,163,37,213,25,201,188,196,4,91,228,207,70,20,130,122,83,98,221,182,58,81,239,37,44,153,26,142,169,37,55,231,37,142,64,178,122,95,126,69,80,39,6,34,32,114,125,18,254,103,147,218,76,220,104,67,120,75,104,135,180,88,243,84,228,155,223,133,68,196,129,219,158,2,82,72,234,165,71,185,190,42,203,2,206,250,42,57,147,159,152,92,242,104,235,41,157,194,67,220,23,228,244,97,246,235,184,73,165,105,210,91,54,216,69,247,65,71,182,32,173,148,226,210,150,127,239,96,107,135,24,182,95,156,166,134,9,169,163,30,106,64,221,100,66,223,128,56,10,169,229,140,158,23,107,38,145,33,188,181,77,161,123,199,102,235,188,221,176,162,226,109,223,160,14,83,171,195,27,82,235,218,137,13,209,46,205,26,35,120,241,194,62,212,202,35,103,47,208,255,246,45,208,31,173,133,167,14,131,193,196,182,211,122,48,10,206,235,59,31,137,251,49,32,169,64,189,219,220,130,27,131,133,164,65,219,135,54,121,103,75,187,250,126,176,88,90,128,228,210,169,26,116,104,123,35,225,249,77,233,217,104,97,229,93,209,197,27,239,68,245,230,214,220,207,186,116,146,95,195,197,26,241,34,111,26,237,67,80,167,120,81,222,2,132,75,30,140,173,161,31,252,82,28,196,53,13,241,167,97,159,238,64,99,167,8,3,210,6,19,24,15,194,203,33,9,110,97,218,33,222,221,223,112,212,124,221,114,35,109,211,245,229,113,210,223,166,70,104,19,250,184,40,104,109,124,208,159,115,185,52,215,52,11,127,166,211,48,186,98,135,88,125,162,197,160,21,34,222,208,7,66,141,52,77,175,75,142,85,145,207,95,220,111,223,136,91,60,235,1,255,135,179,193,177,8,251,133,111,225,55,136,103,239,229,72,235,220,114,233,11,239,122,206,229,238,233,205,167,91,246,151,80,12,187,59,244,249,31,55,33,132,6,109,15,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e54900c1-b29b-45b4-9d54-84bdf396c7ca"));
		}

		#endregion

	}

	#endregion

}

