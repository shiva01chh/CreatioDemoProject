﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ServiceInServicePactEventListenerSchema

	/// <exclude/>
	public class ServiceInServicePactEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ServiceInServicePactEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ServiceInServicePactEventListenerSchema(ServiceInServicePactEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f9c14b2c-fc75-4894-a2c7-6a007396f8e5");
			Name = "ServiceInServicePactEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("9e15b378-783b-44f1-895b-b01e6274a20d");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,197,88,91,111,219,54,20,126,118,129,254,7,86,29,10,9,21,148,188,236,165,109,50,44,183,194,64,186,22,115,186,151,162,15,140,116,236,104,147,41,131,164,60,24,129,255,251,14,47,178,72,137,114,98,119,216,218,135,88,228,185,126,231,70,146,209,37,136,21,205,129,220,1,231,84,212,115,153,93,214,108,94,46,26,78,101,89,179,151,47,30,95,190,152,52,162,100,11,50,219,8,9,203,247,189,111,164,175,42,200,21,177,200,62,2,3,94,230,29,141,43,118,185,172,89,120,135,195,216,122,118,205,100,41,75,16,79,18,100,215,107,96,82,209,33,229,107,14,11,52,136,92,86,84,8,242,142,204,128,175,203,28,166,204,254,248,66,115,169,233,111,75,244,1,109,214,92,39,39,39,228,131,104,150,75,202,55,231,246,91,75,72,137,124,160,146,228,53,147,180,100,130,128,98,37,149,229,21,100,94,243,160,138,172,21,122,226,72,253,166,45,222,120,234,227,89,254,0,75,250,27,134,131,156,145,40,36,43,74,190,35,243,170,185,175,202,156,228,218,175,39,189,66,207,47,168,128,128,66,20,165,2,187,3,234,19,200,135,186,80,80,125,225,229,154,74,208,128,76,86,230,131,8,137,217,144,227,31,174,34,112,3,50,127,64,58,229,209,85,41,86,21,221,252,65,171,6,98,187,47,118,206,164,228,99,83,22,164,44,82,242,85,0,199,212,98,38,85,72,227,125,38,68,91,51,89,83,78,64,91,107,0,65,48,124,66,19,110,187,251,137,50,186,0,142,89,39,167,12,77,100,57,92,108,148,218,184,179,32,121,223,19,140,34,93,13,217,37,7,244,208,136,141,123,86,25,94,67,158,105,175,111,120,189,188,186,136,203,194,238,113,144,13,103,86,98,230,99,130,133,209,44,153,70,70,19,111,131,152,26,205,4,125,104,195,137,69,21,107,216,68,183,48,61,4,65,135,239,199,96,140,28,147,34,7,73,71,1,138,30,168,123,6,166,14,143,7,172,231,178,143,177,179,181,7,206,117,141,192,93,214,171,141,99,250,21,149,52,182,56,139,64,205,184,216,249,214,58,222,121,117,237,135,98,0,12,178,245,226,25,148,130,52,119,155,21,20,78,162,124,80,129,63,247,128,159,22,81,146,246,163,109,218,220,100,50,189,102,205,18,56,189,175,224,131,169,190,115,108,83,74,156,10,160,184,171,21,20,104,14,131,191,109,245,126,251,110,189,157,68,191,3,213,210,238,202,37,104,237,81,26,216,249,202,74,185,219,152,161,236,48,139,187,227,179,96,96,26,17,233,175,173,129,106,96,97,118,83,243,107,154,63,196,221,14,57,59,111,13,189,172,105,5,34,55,10,133,67,147,182,128,167,225,184,26,109,91,251,215,75,60,47,16,51,144,78,12,98,207,253,40,85,177,84,191,102,26,191,216,216,116,104,64,251,136,234,168,30,40,170,100,178,39,201,132,160,21,228,231,136,94,75,118,153,242,44,199,221,32,254,75,142,247,243,226,120,199,135,185,247,60,199,237,80,234,116,216,49,59,58,198,34,199,158,232,80,91,253,2,86,100,99,5,60,176,77,85,187,181,205,174,4,53,216,58,143,35,69,27,245,26,234,222,240,162,254,156,106,247,77,112,67,7,8,51,63,125,131,210,62,122,73,242,116,11,246,106,214,58,234,150,110,219,144,235,134,231,221,103,1,66,150,140,246,71,154,97,252,66,229,3,130,227,208,100,118,226,40,103,244,47,227,239,197,70,145,58,157,34,201,166,226,182,174,255,106,86,10,78,242,11,249,41,122,236,118,183,24,34,60,250,116,11,6,211,114,78,98,87,215,71,31,206,206,166,132,156,97,139,109,170,170,53,121,226,153,56,198,150,90,231,247,8,110,91,216,56,218,22,89,191,84,245,241,65,170,138,43,84,197,165,4,43,136,172,149,240,3,142,17,210,86,236,93,41,171,253,245,210,245,124,79,105,48,229,237,52,71,252,61,249,219,119,228,81,27,184,141,246,164,86,231,236,120,234,6,75,42,37,225,54,208,250,171,66,221,175,194,87,38,166,228,205,155,65,243,120,213,11,247,46,189,219,250,242,143,69,122,229,45,137,240,255,219,190,44,131,202,196,99,237,62,178,91,96,11,76,250,115,242,243,233,41,166,173,179,51,107,238,141,218,248,52,85,187,137,206,224,118,219,138,181,104,247,215,183,4,42,1,173,245,150,40,186,130,57,109,42,73,152,106,16,79,38,158,46,243,155,178,170,218,129,228,246,231,255,230,184,197,7,67,117,76,194,129,147,121,92,133,141,80,28,82,125,166,111,59,217,245,114,37,55,9,6,43,82,77,229,89,85,51,148,54,82,61,250,144,57,152,168,71,120,29,26,203,254,76,234,17,248,109,49,100,195,89,192,141,174,66,2,226,200,144,99,44,69,71,216,71,236,56,54,12,67,105,35,97,216,30,123,150,52,222,96,243,251,241,67,223,150,60,134,208,219,30,116,34,240,15,124,199,90,23,56,153,161,117,161,152,181,214,217,150,242,26,88,97,94,32,236,247,240,57,66,63,120,152,221,254,251,140,93,0,32,57,135,249,89,52,242,214,145,125,102,120,175,5,142,3,121,17,157,116,140,238,163,76,251,176,82,175,129,243,178,0,211,221,28,198,184,190,255,19,83,0,235,140,21,192,219,227,202,5,204,107,14,90,219,175,124,33,200,110,158,220,163,41,174,222,184,229,107,31,36,246,244,71,149,215,102,59,49,92,134,99,239,220,62,164,115,170,250,125,213,123,15,80,119,127,113,131,183,246,6,221,97,234,58,89,196,17,50,135,198,44,126,220,126,154,222,77,111,237,218,231,170,184,105,88,30,37,73,119,97,27,222,191,247,92,208,38,163,83,100,223,173,206,73,163,227,19,227,235,170,160,199,228,69,203,119,92,90,236,184,71,178,98,247,82,117,76,30,216,183,168,255,39,242,163,145,52,86,5,98,215,107,1,102,213,95,196,53,252,247,15,157,166,160,253,172,22,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f9c14b2c-fc75-4894-a2c7-6a007396f8e5"));
		}

		#endregion

	}

	#endregion

}

