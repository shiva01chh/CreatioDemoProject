﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: PortalMessageFileServiceSchema

	/// <exclude/>
	public class PortalMessageFileServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public PortalMessageFileServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public PortalMessageFileServiceSchema(PortalMessageFileServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("82979e3f-cad6-4131-ab9f-5fac8a969ecc");
			Name = "PortalMessageFileService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c85d2d65-6230-4aeb-9934-bfac9785d42f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,221,87,75,111,26,73,16,62,59,82,254,67,137,92,64,98,135,123,108,136,18,123,237,101,21,7,11,200,230,96,173,86,205,76,1,173,157,153,158,116,247,96,17,228,255,190,213,143,129,121,98,39,199,245,193,210,84,215,227,235,170,175,170,154,148,37,168,50,22,34,44,81,74,166,196,90,7,215,34,93,243,77,46,153,230,34,125,251,230,240,246,205,69,174,120,186,129,197,94,105,76,46,107,223,164,31,199,24,26,101,21,220,97,138,146,135,13,157,233,172,33,154,231,169,230,9,6,11,50,96,49,255,97,195,53,180,232,116,199,67,188,23,17,198,103,15,131,143,4,97,247,178,147,224,27,174,78,10,167,91,147,152,110,146,36,34,45,212,231,34,215,164,115,82,62,169,144,140,164,239,36,110,40,28,192,117,204,148,122,15,115,100,17,233,205,50,155,11,171,50,26,141,224,74,229,73,194,228,126,226,191,189,26,80,230,21,219,160,2,225,12,130,66,127,84,50,120,188,97,154,81,69,180,100,161,254,155,4,89,190,138,121,8,161,9,217,136,120,113,176,81,143,200,30,164,200,80,106,142,132,238,193,26,186,243,58,44,43,184,22,84,17,16,107,144,226,73,129,22,176,66,144,168,37,199,29,70,193,209,172,140,206,193,187,199,100,133,178,255,133,184,4,99,232,145,185,117,213,27,24,188,5,96,78,190,231,254,4,14,176,65,125,9,202,252,123,62,3,137,46,169,33,22,44,194,8,118,44,206,241,39,96,24,219,191,140,77,21,199,93,206,35,248,92,156,181,33,121,135,105,228,242,103,191,157,180,38,172,151,254,65,72,205,226,91,30,99,65,30,106,43,42,9,190,158,5,210,91,252,2,13,58,163,195,123,168,116,115,3,92,65,152,182,4,58,175,247,14,159,113,174,170,153,156,254,158,230,9,74,182,138,241,170,161,123,179,156,77,160,233,161,37,223,103,243,219,149,222,206,180,58,205,34,171,176,38,19,10,102,109,58,18,139,107,150,199,186,212,243,104,46,249,184,80,89,83,230,4,229,58,60,126,84,217,23,212,52,22,50,202,240,138,199,92,239,231,248,61,231,18,19,76,181,234,151,63,204,0,162,204,190,96,98,180,2,47,136,6,29,197,46,37,213,163,162,90,127,98,234,148,32,83,218,142,73,32,133,166,129,141,145,171,125,38,205,220,68,152,54,60,27,142,162,132,127,178,70,29,221,201,101,225,192,251,235,118,209,100,130,63,24,219,254,189,232,12,1,31,62,64,191,251,116,12,41,62,117,122,239,127,165,210,83,181,82,183,158,6,131,203,214,14,63,38,233,30,245,86,68,175,153,149,119,168,33,107,82,77,117,204,39,43,201,152,100,9,164,212,93,227,94,229,66,211,168,55,169,241,54,79,249,247,28,121,68,124,224,107,142,50,184,26,89,243,118,111,178,178,6,122,147,218,108,41,22,12,93,3,17,66,137,235,113,175,186,57,122,163,73,51,2,205,254,92,166,106,98,232,206,56,237,117,120,226,122,219,214,97,10,194,227,27,160,28,164,115,46,185,120,69,0,59,128,102,68,79,59,163,202,221,117,241,72,59,119,154,238,196,191,216,119,197,177,131,105,182,88,246,134,96,90,4,149,190,21,50,97,154,228,164,90,80,192,138,130,63,149,72,135,240,73,68,251,133,222,199,88,81,57,74,131,111,146,101,25,70,67,203,195,2,224,121,167,149,49,216,61,124,137,36,77,102,246,21,109,84,170,77,141,1,195,218,46,135,106,77,7,96,187,249,98,199,164,89,20,52,176,42,212,111,137,222,55,100,39,11,167,29,180,140,226,113,103,223,4,237,200,27,144,107,24,139,128,166,170,30,165,111,184,115,59,254,51,173,119,5,44,12,201,47,167,93,98,25,245,218,62,218,114,165,133,220,47,194,45,38,204,44,174,222,196,174,47,122,197,40,43,131,181,144,224,181,32,162,37,119,190,147,60,171,255,112,6,166,49,167,199,30,180,79,35,12,133,140,128,104,94,248,116,97,206,123,53,55,50,190,76,26,225,212,212,254,141,229,222,55,221,253,183,208,148,231,196,68,183,219,204,95,226,149,205,67,149,236,127,149,124,137,73,22,155,33,79,237,211,86,220,209,161,145,201,231,209,161,158,13,18,185,171,60,87,95,2,30,97,155,227,130,238,13,247,67,240,39,245,32,199,3,23,170,96,190,167,213,79,81,182,223,18,181,25,206,199,185,124,137,168,55,24,163,166,190,105,153,251,176,218,195,134,239,48,45,87,151,10,214,162,250,75,27,226,214,19,104,250,162,247,78,22,45,101,78,183,231,158,68,79,76,65,100,239,67,9,16,122,139,242,137,211,196,250,13,214,44,86,248,191,153,205,43,33,98,95,183,38,57,236,47,129,150,52,151,103,109,24,35,75,187,223,25,215,238,184,254,206,168,12,66,239,34,232,130,209,134,160,204,197,242,99,165,245,177,76,50,243,247,31,91,203,200,4,203,15,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("82979e3f-cad6-4131-ab9f-5fac8a969ecc"));
		}

		#endregion

	}

	#endregion

}

