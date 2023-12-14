﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: InitialSendingMailingStateSchema

	/// <exclude/>
	public class InitialSendingMailingStateSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public InitialSendingMailingStateSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public InitialSendingMailingStateSchema(InitialSendingMailingStateSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3b51f0b4-7199-4cf5-95f1-0435b6165dfc");
			Name = "InitialSendingMailingState";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,189,88,91,111,219,54,20,126,118,129,254,7,86,29,10,9,203,232,14,3,246,16,199,25,154,196,238,12,36,65,48,59,235,67,81,12,140,116,108,19,149,73,141,164,156,100,129,255,251,14,41,234,26,219,241,138,98,121,137,68,157,235,119,110,60,22,108,5,58,99,49,144,25,40,197,180,156,27,122,46,197,156,47,114,197,12,151,226,245,171,167,215,175,122,185,230,98,65,166,143,218,192,106,80,189,239,96,161,87,76,125,5,131,20,244,214,240,148,27,14,122,59,147,2,122,113,134,159,240,227,91,5,11,228,37,231,41,211,250,152,76,4,178,177,116,10,34,65,166,43,134,98,196,98,106,152,1,71,221,239,247,201,137,206,87,43,166,30,79,253,187,39,34,218,82,17,179,100,134,240,85,150,194,10,132,209,228,54,75,236,241,93,158,126,37,176,66,82,71,151,107,50,151,202,62,42,227,120,81,31,201,148,140,65,107,90,234,233,55,20,101,249,93,202,99,18,91,43,247,24,73,142,73,219,230,222,147,179,187,114,243,70,201,12,148,69,230,216,62,27,136,13,36,5,73,86,190,18,185,70,172,120,2,104,159,178,214,141,148,146,234,10,77,99,11,152,186,163,115,137,95,135,167,36,56,67,191,70,214,173,169,243,170,240,118,180,70,215,131,193,139,98,45,217,101,252,79,71,228,110,239,74,145,111,241,83,225,207,30,231,28,96,222,132,2,188,74,255,199,156,39,159,191,144,15,107,148,205,238,82,24,75,53,122,128,56,183,73,84,248,1,218,154,34,224,158,32,157,77,196,94,207,27,130,25,167,141,166,29,191,63,49,110,227,120,6,24,85,176,150,79,146,163,151,185,62,196,134,175,225,32,210,169,205,148,155,148,9,64,209,150,124,243,2,22,87,96,150,50,113,81,230,235,50,125,49,24,238,197,33,64,62,130,65,11,114,230,85,132,149,74,151,173,238,41,242,206,175,153,42,178,119,244,144,113,133,177,28,214,52,212,157,185,10,188,176,178,79,137,253,55,227,43,160,87,92,252,201,210,28,200,187,119,78,76,111,23,19,157,201,91,129,88,40,205,82,203,25,70,228,164,22,115,107,226,107,121,63,112,34,20,152,92,9,210,182,230,55,178,23,60,79,54,73,234,242,216,131,178,158,36,78,213,166,9,216,90,34,96,83,48,53,67,134,13,198,3,231,208,212,246,96,6,218,96,60,11,124,239,218,194,39,73,137,166,81,143,254,201,1,123,215,146,137,208,218,188,107,43,10,209,94,3,15,134,222,106,80,248,44,176,162,16,186,168,192,164,199,231,36,124,211,22,67,199,96,226,229,88,201,213,197,89,216,176,45,42,141,168,18,174,234,149,244,82,46,168,171,117,44,136,21,51,161,167,235,5,159,119,215,36,221,1,202,151,99,50,198,19,12,142,145,100,110,109,233,184,68,230,104,27,185,56,163,1,249,177,82,52,73,142,201,211,251,77,112,212,132,179,244,210,199,222,191,109,106,215,159,1,77,134,195,195,2,93,37,102,175,131,222,33,146,106,103,91,213,89,3,220,149,9,230,92,166,249,170,168,137,48,40,117,160,183,47,171,184,100,185,136,151,78,254,247,0,96,204,5,215,203,182,185,54,23,53,164,152,90,231,50,23,101,34,78,221,201,174,4,164,133,71,225,24,173,163,142,45,196,32,6,81,68,109,234,133,245,124,8,162,50,200,244,211,18,148,117,191,142,112,16,209,137,30,253,141,173,40,44,228,209,27,166,240,134,96,64,181,115,151,126,16,73,3,184,90,230,68,95,75,179,67,194,161,64,68,132,105,239,238,160,1,73,236,193,104,64,67,139,113,1,211,152,165,76,157,112,97,78,195,42,75,109,64,60,207,144,188,175,225,253,174,233,208,48,187,212,219,243,99,213,216,145,118,141,190,163,205,63,4,211,217,95,79,13,8,177,209,158,49,13,191,252,26,70,155,160,226,172,91,192,5,142,208,153,21,16,86,98,142,200,246,216,31,17,163,114,168,212,111,90,89,217,245,149,173,161,68,104,67,98,102,219,65,56,122,136,33,179,146,8,84,40,29,218,147,190,177,37,57,73,228,126,137,141,105,223,45,170,211,169,238,185,89,146,170,53,121,11,96,91,143,218,248,193,177,127,116,236,28,183,126,112,232,206,188,104,13,9,91,220,142,140,142,86,153,121,28,116,39,74,155,176,30,184,126,170,53,103,240,158,12,172,76,120,206,212,8,101,243,184,234,60,21,239,96,75,131,162,141,170,39,111,154,142,212,133,178,107,204,110,21,242,220,212,205,158,76,154,136,185,244,137,84,183,166,86,124,177,204,141,29,89,79,63,111,188,100,138,112,52,64,125,166,240,127,206,231,111,77,229,157,89,220,240,173,132,176,98,42,174,232,114,177,0,101,45,119,58,195,22,24,157,75,90,41,23,239,150,213,205,222,103,215,158,85,33,58,34,104,200,22,30,155,108,197,246,161,23,72,229,133,111,239,71,244,60,87,10,165,217,83,187,24,26,22,55,46,15,102,169,202,43,100,179,72,15,184,62,183,150,164,238,2,232,14,126,103,34,73,113,101,48,75,187,219,64,86,64,109,159,126,210,25,196,124,142,203,71,42,23,60,166,149,136,126,87,198,73,113,185,209,167,19,236,249,76,224,98,44,231,168,9,128,196,10,230,195,160,25,212,106,89,249,3,116,158,154,160,127,74,79,250,37,255,142,157,107,15,191,183,127,138,246,78,16,88,37,112,136,110,109,61,88,219,117,215,138,202,40,212,201,34,12,47,27,146,229,99,141,229,194,246,172,206,186,81,47,25,5,203,150,22,217,104,140,77,97,158,225,165,10,47,2,255,31,43,171,188,25,98,133,225,197,148,4,22,21,82,78,91,90,151,19,182,47,172,35,90,22,82,179,207,70,173,77,197,222,161,246,128,31,154,37,215,20,177,153,61,102,216,87,171,198,49,205,99,251,99,0,226,102,167,172,215,82,97,185,85,96,241,149,94,72,1,69,158,15,170,68,223,146,234,69,1,180,15,221,153,253,251,23,103,127,91,94,159,17,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3b51f0b4-7199-4cf5-95f1-0435b6165dfc"));
		}

		#endregion

	}

	#endregion

}

