﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ExcelNumberFormatAttributeSchema

	/// <exclude/>
	public class ExcelNumberFormatAttributeSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ExcelNumberFormatAttributeSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ExcelNumberFormatAttributeSchema(ExcelNumberFormatAttributeSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5641821c-39ed-4a72-847f-ca3f93100c38");
			Name = "ExcelNumberFormatAttribute";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,84,77,111,218,64,16,61,27,137,255,48,82,46,70,162,38,105,111,161,84,66,1,212,92,82,162,64,83,169,234,97,177,199,102,165,245,174,179,31,45,20,229,191,119,189,139,45,3,14,228,80,75,24,237,206,155,121,239,205,12,112,146,163,42,72,140,176,64,41,137,18,169,142,238,4,79,105,102,36,209,84,240,104,186,41,132,212,11,49,221,196,200,186,157,93,183,211,237,4,70,81,158,193,211,86,105,204,135,245,121,34,98,147,35,215,51,33,115,162,163,111,5,242,31,57,187,20,143,158,10,137,36,81,107,68,61,116,213,175,36,102,150,26,238,24,81,234,22,28,243,131,201,87,40,125,230,88,107,73,87,70,163,67,15,6,3,248,172,76,158,19,185,253,178,63,215,8,72,133,132,4,99,81,186,177,18,176,172,5,246,195,202,136,173,5,200,77,14,41,69,150,68,85,177,65,163,218,207,186,212,82,145,12,195,250,184,32,50,67,173,162,89,153,218,251,101,161,133,89,49,26,67,92,170,62,35,26,110,161,97,32,240,13,173,61,207,165,40,80,106,138,214,248,220,21,244,241,99,151,238,194,145,0,119,44,149,31,234,124,156,26,169,228,45,239,185,254,244,17,154,210,96,7,214,202,16,94,47,82,165,140,100,125,80,107,97,88,2,70,225,158,219,83,211,228,44,241,74,8,6,227,162,96,219,255,196,221,152,229,111,194,12,194,139,17,182,189,118,155,82,186,185,44,229,177,68,207,29,248,253,34,98,193,76,206,225,15,77,244,250,124,159,39,194,126,227,119,39,236,185,132,191,159,196,187,89,11,73,255,10,174,9,3,194,104,198,203,95,206,121,202,175,117,198,184,74,112,252,170,45,114,36,231,10,121,226,87,240,112,31,237,159,129,210,210,196,90,200,163,141,220,147,190,189,232,161,107,51,57,158,120,31,202,236,32,216,47,34,111,46,195,8,174,151,85,60,113,13,244,173,182,129,155,235,73,223,7,168,21,191,110,49,52,130,15,55,85,178,163,126,105,76,120,4,41,97,10,123,176,115,128,135,67,214,166,136,161,3,156,46,234,232,212,138,135,62,239,21,54,38,30,205,164,200,253,57,116,6,122,30,250,120,160,168,161,207,135,105,10,225,212,106,137,238,213,196,222,114,76,66,189,45,80,164,225,155,163,237,245,219,122,209,171,124,6,109,147,31,193,153,122,45,213,188,184,215,242,221,190,45,254,246,240,210,222,53,159,127,87,20,79,195,105,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5641821c-39ed-4a72-847f-ca3f93100c38"));
		}

		#endregion

	}

	#endregion

}

