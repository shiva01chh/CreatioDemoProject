﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ForecastHistoryMatcherSchema

	/// <exclude/>
	public class ForecastHistoryMatcherSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ForecastHistoryMatcherSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ForecastHistoryMatcherSchema(ForecastHistoryMatcherSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2663de06-d978-7844-8986-9c48b9483ba2");
			Name = "ForecastHistoryMatcher";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,86,93,107,219,48,20,125,118,97,255,225,46,131,226,64,113,96,143,109,146,209,181,75,23,104,217,104,75,95,198,30,84,251,58,17,147,165,76,146,83,194,232,127,159,36,203,142,19,43,77,203,62,94,182,60,196,182,116,116,63,206,189,231,218,156,20,168,22,36,69,184,69,41,137,18,185,78,206,4,207,233,172,148,68,83,193,147,137,144,152,18,165,239,222,190,58,248,241,234,32,42,21,229,51,184,89,41,141,133,129,50,134,169,197,169,228,2,57,74,154,158,108,99,46,41,255,190,94,108,187,145,152,76,72,170,133,164,168,12,194,96,222,72,156,25,99,48,229,26,101,110,194,58,134,105,29,192,71,170,12,116,117,69,116,58,71,233,224,131,193,0,134,170,44,10,34,87,99,255,252,89,138,37,205,80,65,129,122,46,50,5,90,64,65,190,33,228,222,14,40,78,22,106,46,180,74,106,19,131,150,141,69,121,207,104,10,180,142,96,119,0,145,165,163,19,131,91,112,24,208,18,17,52,185,103,8,25,209,36,105,224,131,109,252,112,65,36,41,128,155,106,140,122,12,115,189,38,182,55,190,157,163,201,192,112,41,33,109,150,109,90,169,40,204,57,76,140,65,119,62,108,78,210,217,188,99,79,49,178,196,103,155,147,168,75,201,213,120,168,76,66,169,196,124,212,187,153,35,234,222,96,60,28,212,155,22,61,253,192,203,2,165,77,121,232,233,186,53,36,220,218,133,115,67,193,212,52,196,184,98,39,110,99,3,160,77,22,142,172,245,104,207,145,173,76,251,85,79,61,89,33,87,28,67,67,89,112,245,47,22,201,49,120,230,242,15,214,165,189,189,183,34,109,112,160,22,209,99,165,113,228,89,37,243,13,201,159,49,162,212,49,212,98,187,241,34,189,34,156,204,94,44,119,91,219,70,239,182,172,64,120,6,21,9,64,32,163,121,30,20,127,229,1,145,48,37,60,135,59,228,223,131,129,61,240,229,28,115,82,50,253,158,242,204,140,183,88,175,22,40,242,120,199,161,126,255,235,122,194,164,54,97,8,3,159,24,123,118,234,88,234,107,222,174,170,188,143,13,19,116,73,52,86,187,139,234,1,150,130,102,48,161,140,85,117,185,35,172,68,21,239,146,38,112,124,184,22,15,71,208,221,177,197,183,55,85,217,187,251,174,222,246,174,15,110,44,70,149,169,164,237,23,70,214,1,92,26,239,205,116,112,61,131,140,141,99,215,34,81,100,203,70,76,249,226,102,171,241,221,178,101,230,115,179,188,225,163,118,31,45,137,180,222,156,129,202,239,182,203,56,96,215,7,225,78,55,41,181,253,142,214,203,239,54,28,39,19,42,149,254,36,125,67,196,233,18,70,227,202,88,148,46,61,116,154,193,104,20,202,103,189,127,120,8,6,126,33,69,185,216,141,246,219,117,180,52,135,56,24,237,107,147,121,201,88,67,74,228,25,73,78,83,93,18,214,73,169,237,195,253,123,7,143,213,37,80,211,228,52,203,98,111,213,135,227,192,143,190,75,55,197,30,232,90,39,134,253,131,250,239,188,74,193,75,131,166,132,245,127,243,200,134,184,34,61,100,247,217,179,219,207,142,63,252,158,125,233,139,214,183,151,19,141,120,8,234,188,99,164,171,247,157,51,167,22,123,215,99,173,114,211,149,91,34,223,54,214,136,189,214,140,13,180,110,94,115,60,40,252,90,26,107,199,219,42,167,14,53,6,123,77,174,49,21,50,219,84,109,179,24,212,170,69,118,4,106,37,230,211,184,209,118,136,143,160,253,152,156,35,67,141,217,166,52,59,51,190,30,229,205,224,110,141,232,150,78,35,255,82,180,116,156,180,132,251,255,163,105,175,240,126,225,219,105,183,157,29,210,242,85,106,100,213,62,227,149,20,158,184,161,111,46,183,102,126,63,1,203,212,71,223,253,13,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2663de06-d978-7844-8986-9c48b9483ba2"));
		}

		#endregion

	}

	#endregion

}

