﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MailingResponseCodeSchema

	/// <exclude/>
	public class MailingResponseCodeSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MailingResponseCodeSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MailingResponseCodeSchema(MailingResponseCodeSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f16fb810-609b-4c01-9b2c-447b893d5c8f");
			Name = "MailingResponseCode";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c79d6b8e-4dfb-4af0-8a52-3dfabe5c47b0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,86,93,79,91,49,12,125,6,137,255,96,105,15,99,18,162,163,3,246,201,30,104,129,33,49,198,104,217,123,122,227,66,198,189,201,93,62,42,85,211,254,251,236,228,182,84,26,73,187,74,149,218,196,231,28,219,113,236,104,209,160,107,69,133,48,70,107,133,51,83,191,63,48,122,170,238,131,21,94,25,13,191,119,182,183,130,83,250,30,70,115,231,177,249,184,179,77,43,47,44,222,243,238,153,14,205,7,248,42,84,77,22,183,68,101,180,195,129,145,24,173,122,189,30,124,114,161,105,132,157,127,238,254,47,140,160,34,43,80,26,154,4,222,95,216,247,86,0,109,152,212,170,2,36,149,231,68,162,115,255,168,196,133,11,212,104,69,13,22,127,5,116,30,166,132,14,22,247,151,128,85,153,173,219,100,117,78,70,40,225,4,14,246,162,255,207,83,143,80,251,12,15,111,17,188,95,130,223,98,165,102,164,50,153,67,107,205,76,73,180,176,43,177,22,115,148,175,50,188,67,156,242,241,212,196,253,166,204,253,19,43,143,50,27,102,218,38,154,195,61,94,200,18,93,234,202,88,75,198,32,164,180,232,28,230,82,119,169,103,162,86,76,121,84,166,124,54,110,74,123,200,135,253,61,238,18,245,113,153,58,166,221,155,37,111,134,238,198,80,1,203,155,133,248,9,188,45,229,242,139,176,18,78,77,208,85,46,116,182,72,6,196,245,174,88,50,173,104,114,37,67,91,4,127,95,130,223,105,23,38,202,85,86,77,114,190,68,19,174,220,215,37,162,43,165,31,193,180,168,51,44,3,186,109,143,233,6,20,107,120,68,125,162,156,27,182,88,230,230,160,88,180,55,181,208,58,91,179,221,46,179,28,150,88,190,81,84,89,146,180,201,28,71,37,142,129,32,127,185,3,236,6,78,103,74,184,132,90,57,159,43,209,5,100,104,174,141,191,115,120,198,237,140,133,138,7,250,36,164,186,235,131,140,91,39,210,221,181,133,70,191,120,214,171,26,139,203,188,161,74,103,190,212,41,182,195,39,157,9,29,213,227,102,26,167,108,186,228,47,214,218,19,191,127,64,75,35,195,129,54,64,147,168,173,133,71,106,240,45,21,173,128,169,177,244,187,82,173,162,102,176,78,126,220,161,233,204,206,169,72,185,50,250,27,86,134,67,77,205,227,165,3,105,200,125,77,190,120,152,161,85,83,69,125,172,172,58,138,80,55,140,64,146,254,209,193,88,253,248,63,213,53,13,238,164,205,21,177,153,240,53,97,88,182,235,215,253,98,251,27,199,100,11,254,214,22,133,156,131,11,213,67,58,93,30,219,236,9,191,10,68,144,148,241,108,31,24,134,120,60,221,208,41,55,149,196,152,31,173,81,143,88,138,221,36,197,28,147,85,153,166,9,154,213,249,169,82,171,70,249,53,137,26,172,34,174,24,192,87,249,160,60,125,50,93,131,114,148,146,213,173,181,204,233,120,252,165,101,63,111,113,141,59,119,43,124,167,243,49,1,56,252,195,24,253,159,244,14,163,172,164,167,216,206,118,92,161,207,95,219,99,65,62,212,9,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f16fb810-609b-4c01-9b2c-447b893d5c8f"));
		}

		#endregion

	}

	#endregion

}

