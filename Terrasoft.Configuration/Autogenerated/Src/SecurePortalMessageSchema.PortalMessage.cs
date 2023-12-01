﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SecurePortalMessageSchema

	/// <exclude/>
	public class SecurePortalMessageSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SecurePortalMessageSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SecurePortalMessageSchema(SecurePortalMessageSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6331365c-05cc-4af7-b843-12c8b416ba92");
			Name = "SecurePortalMessage";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("954528c0-fb67-4d4c-88f7-007a094e70cf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,86,223,147,218,54,16,126,118,102,242,63,104,232,139,153,97,196,123,115,199,12,33,185,132,118,104,232,145,54,143,25,97,47,160,214,150,136,126,28,117,59,249,223,187,210,218,96,3,230,122,133,23,180,218,253,246,219,213,234,19,74,148,96,247,34,3,246,25,140,17,86,111,28,159,105,181,145,91,111,132,147,90,189,126,245,207,235,87,137,183,82,109,217,170,178,14,202,55,103,107,254,232,149,147,37,240,21,24,41,10,249,119,140,187,240,194,221,39,153,193,66,231,80,220,220,228,211,204,201,167,231,65,248,23,88,159,28,218,244,203,178,29,218,222,49,208,103,231,239,222,246,110,189,199,250,156,4,123,205,1,73,220,200,120,218,109,168,63,106,239,208,7,157,195,55,249,193,192,22,11,101,179,66,88,251,35,91,65,230,13,44,181,113,162,88,128,181,98,11,209,109,60,30,179,59,235,203,82,152,106,82,175,151,70,63,201,28,44,219,120,149,133,110,97,239,93,197,54,218,176,131,54,127,6,34,7,233,118,140,208,88,73,112,76,175,255,128,204,141,216,97,39,179,29,147,54,4,172,101,158,131,138,161,217,78,168,109,136,93,87,108,79,145,222,130,177,188,97,49,110,209,216,251,117,33,51,150,5,242,215,185,39,97,122,142,85,62,72,40,114,44,115,105,194,1,83,105,201,158,22,204,128,200,181,42,42,246,27,230,195,25,84,16,171,98,95,125,103,29,218,156,68,80,80,57,225,18,206,177,149,90,89,103,124,230,180,9,169,34,197,58,19,209,189,66,52,61,203,217,77,57,100,177,138,228,140,9,187,103,87,168,125,175,217,244,176,91,128,219,233,222,30,172,160,64,40,246,1,92,135,30,153,211,15,94,230,205,57,126,148,22,11,172,230,249,136,97,181,225,192,118,100,89,101,59,40,197,47,120,175,27,218,79,194,48,176,223,144,174,130,3,139,195,92,123,253,234,193,84,233,89,89,188,237,177,16,10,147,153,209,21,244,88,109,130,192,28,75,9,19,17,209,102,186,240,165,226,115,59,45,14,162,178,117,65,247,12,79,4,222,28,233,236,41,226,103,168,30,100,225,192,160,67,0,154,225,12,56,32,211,23,156,221,165,48,152,9,23,54,37,35,222,165,189,48,210,106,245,185,218,227,197,252,230,69,49,138,168,145,200,163,214,142,24,242,208,66,74,66,140,2,229,116,56,186,104,95,171,12,74,97,249,52,207,211,115,130,195,19,247,76,88,88,116,80,142,69,6,20,76,76,235,171,205,173,113,250,48,168,20,62,71,119,243,147,150,42,29,116,230,96,48,228,83,139,182,197,96,72,158,9,255,164,226,122,196,6,243,252,100,157,219,216,154,244,226,212,208,239,17,50,109,242,224,125,155,11,167,198,53,240,31,81,107,62,41,162,243,194,208,7,163,203,255,21,24,14,249,63,16,237,107,87,8,63,182,140,22,221,182,69,91,79,235,94,70,225,196,187,193,12,221,238,36,39,3,225,24,112,222,168,222,81,122,153,144,180,20,238,252,157,136,6,156,72,219,104,121,243,10,8,135,162,177,246,14,159,143,140,134,19,114,230,52,187,219,135,43,103,96,195,20,210,189,31,156,95,151,193,248,8,219,121,9,200,18,131,251,34,39,221,74,25,206,19,10,205,70,130,225,119,227,24,121,29,232,98,134,7,19,250,29,247,153,222,52,218,84,63,109,151,104,212,109,59,89,246,245,0,67,26,159,219,239,196,244,212,182,7,112,217,238,180,126,91,117,203,235,17,107,154,178,231,20,187,22,20,219,232,74,207,123,112,249,20,244,169,52,33,241,247,127,97,73,14,86,152,188,0,210,129,52,60,187,65,128,39,241,117,184,93,51,177,75,218,82,128,236,8,33,8,31,221,130,223,69,225,225,110,173,117,49,73,207,100,163,174,255,36,8,207,133,183,165,163,14,110,93,238,153,216,215,15,241,117,16,234,243,164,123,3,47,97,122,227,195,25,98,116,163,1,49,240,251,136,225,95,184,103,26,101,111,237,118,53,224,166,235,13,33,32,107,215,136,54,252,252,11,240,22,0,40,212,11,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6331365c-05cc-4af7-b843-12c8b416ba92"));
		}

		#endregion

	}

	#endregion

}

