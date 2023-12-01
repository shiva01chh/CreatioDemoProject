﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SocialMentionExecutorSchema

	/// <exclude/>
	public class SocialMentionExecutorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SocialMentionExecutorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SocialMentionExecutorSchema(SocialMentionExecutorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c9db37dc-bcfe-6d55-835b-4d895b23c1d7");
			Name = "SocialMentionExecutor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b66b5ae8-46e0-4931-ad78-c2c1ba5fd6ea");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,86,93,79,219,48,20,125,14,18,255,193,235,94,28,9,133,119,54,152,74,41,83,165,193,208,10,219,195,52,33,147,220,182,214,18,167,216,78,71,133,248,239,187,142,157,196,249,104,97,203,91,174,175,239,57,62,247,195,22,44,3,181,102,49,144,91,144,146,169,124,161,163,73,46,22,124,89,72,166,121,46,162,233,252,250,240,224,249,240,32,40,20,23,75,50,223,42,13,217,135,206,63,238,73,83,136,205,6,21,125,6,1,146,199,61,159,47,92,60,246,140,183,240,164,163,111,176,44,82,38,167,79,107,9,74,153,32,141,159,207,43,203,114,49,188,34,97,151,61,186,56,223,185,116,201,98,157,75,14,30,220,84,104,174,183,243,120,5,25,35,167,221,13,229,42,250,71,190,27,110,198,237,239,37,44,145,57,33,147,148,41,117,66,230,121,204,89,122,5,194,136,50,125,130,184,64,168,210,243,248,248,152,124,228,98,133,34,233,36,143,201,241,25,26,127,94,192,130,21,169,62,231,34,65,30,84,111,215,144,47,232,96,148,48,252,133,59,214,197,67,202,99,18,27,184,97,180,19,50,219,193,34,120,46,153,212,164,49,229,74,203,194,168,129,212,111,202,200,214,195,161,12,198,161,119,10,36,110,21,54,243,164,104,253,134,196,84,77,16,220,183,205,40,106,219,96,180,15,94,28,31,16,137,165,212,230,119,201,33,77,12,51,201,55,76,131,163,102,127,136,4,150,228,34,221,146,14,157,251,30,206,62,136,27,153,175,65,154,228,238,128,105,85,198,189,242,5,169,235,96,135,247,188,239,76,78,207,172,58,3,129,200,167,79,132,14,46,156,118,15,85,198,8,90,229,120,197,4,91,130,196,54,212,51,204,42,19,49,156,111,175,177,207,233,168,197,99,20,134,175,72,114,5,122,149,183,100,111,206,55,155,138,34,3,201,30,82,248,248,185,224,201,25,65,60,23,25,233,105,236,44,53,75,168,89,34,56,98,20,82,154,37,71,3,219,98,235,60,75,84,85,48,27,38,137,2,51,78,240,188,2,254,144,121,249,67,59,71,15,221,217,47,184,210,92,224,122,101,192,89,84,100,2,79,187,85,227,36,227,226,78,112,61,58,34,163,73,133,52,170,60,47,101,158,117,252,194,104,172,186,38,231,253,3,59,22,69,28,35,250,6,42,107,16,205,212,244,177,96,41,181,176,209,13,147,168,181,6,73,177,161,32,172,54,143,69,242,6,70,24,77,208,70,145,200,157,188,182,96,213,144,30,78,189,26,182,208,194,232,58,71,81,162,233,19,10,164,168,3,120,85,79,95,192,86,185,12,242,173,53,108,87,150,21,177,109,171,119,56,29,123,209,43,131,43,150,102,199,30,141,235,210,10,155,248,86,234,55,112,111,226,190,158,153,144,48,229,132,43,251,60,144,160,11,41,92,161,70,118,36,66,83,221,52,145,38,89,73,217,135,150,246,119,150,22,174,234,169,15,16,70,183,249,23,204,17,13,253,81,88,53,218,38,199,14,154,224,140,211,80,245,149,59,149,250,175,238,90,224,61,198,226,21,161,166,205,154,194,226,98,192,55,176,184,14,143,122,72,77,205,89,53,94,246,51,175,34,116,9,151,255,77,44,127,0,180,46,156,114,188,225,52,24,24,164,145,69,176,46,189,154,182,236,6,130,97,107,105,188,114,189,204,40,186,223,219,115,165,189,90,61,106,78,245,15,81,154,34,232,43,58,184,159,109,128,170,42,8,210,47,227,156,144,5,75,21,132,111,185,72,155,145,238,221,241,131,15,146,234,230,223,112,169,177,69,108,54,59,3,190,151,79,124,68,152,71,148,179,84,249,172,29,162,201,10,226,223,99,185,196,42,21,122,154,173,49,99,2,59,25,31,58,94,35,219,243,243,5,169,140,216,166,215,69,154,126,149,63,86,92,195,220,60,87,105,88,215,168,109,68,175,12,131,86,101,43,44,27,251,114,188,211,60,181,175,55,156,31,10,12,119,101,166,215,188,36,93,129,121,240,239,188,73,60,22,219,183,98,170,203,92,58,161,16,123,240,90,28,234,36,229,144,119,244,122,127,139,135,179,47,247,214,218,54,150,54,252,254,2,120,100,118,57,255,11,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c9db37dc-bcfe-6d55-835b-4d895b23c1d7"));
		}

		#endregion

	}

	#endregion

}
