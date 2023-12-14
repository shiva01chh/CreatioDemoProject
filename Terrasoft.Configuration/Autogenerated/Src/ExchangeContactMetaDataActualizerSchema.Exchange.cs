﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ExchangeContactMetaDataActualizerSchema

	/// <exclude/>
	public class ExchangeContactMetaDataActualizerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ExchangeContactMetaDataActualizerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ExchangeContactMetaDataActualizerSchema(ExchangeContactMetaDataActualizerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c7f3f3bd-75f9-4e4a-b48b-87077553380b");
			Name = "ExchangeContactMetaDataActualizer";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("77ff850a-3558-415d-9b34-1a36190e74f6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,189,85,201,110,219,48,16,61,43,64,254,97,170,92,28,32,176,219,171,183,34,141,147,64,135,182,65,157,91,209,3,77,142,108,182,18,105,144,84,82,39,200,191,119,72,73,142,44,111,233,161,245,77,156,55,219,155,55,99,80,44,71,187,100,28,225,30,141,97,86,167,174,123,165,85,42,231,133,97,78,106,117,122,242,124,122,18,21,86,170,57,76,87,214,97,78,246,44,67,238,141,182,123,139,10,141,228,131,53,166,25,198,96,247,134,113,167,141,68,75,8,194,156,25,156,147,31,92,101,204,218,62,80,38,71,128,207,232,216,132,57,118,201,93,193,50,249,132,38,128,123,189,30,12,109,145,231,204,172,198,213,119,112,4,153,47,51,204,145,156,125,21,160,83,194,33,2,55,152,142,226,100,186,82,124,97,180,146,79,193,236,147,24,95,178,137,123,99,72,181,1,94,166,181,144,83,98,65,137,129,85,153,131,67,183,206,221,107,36,255,62,193,148,21,153,251,36,149,160,62,59,110,181,68,157,118,246,39,59,191,128,47,68,46,140,32,190,254,205,23,76,205,113,111,187,241,249,15,74,177,44,102,153,228,192,67,139,71,125,160,239,231,225,211,239,162,47,122,14,20,174,9,39,204,66,11,162,252,206,104,71,195,67,81,218,219,28,135,135,41,58,96,66,72,223,16,203,96,201,12,53,226,140,13,228,213,84,225,154,61,219,93,71,234,181,67,13,131,51,120,153,141,98,26,152,116,171,41,95,96,206,60,55,241,120,216,11,246,0,95,214,149,129,126,32,17,73,129,240,160,165,240,213,248,46,239,234,42,58,214,25,175,180,118,180,115,240,74,141,162,242,229,171,17,196,209,8,18,59,161,50,101,246,138,235,108,59,126,132,15,68,231,251,65,240,255,134,57,21,146,144,210,247,204,47,46,113,83,18,54,38,130,0,13,187,117,182,219,130,87,184,224,244,114,128,245,91,98,93,82,0,166,104,27,55,37,93,79,56,81,169,38,17,255,51,190,155,121,124,61,205,239,78,50,145,97,233,41,221,176,28,193,5,232,217,79,10,49,174,37,130,198,214,83,48,232,10,163,64,225,99,123,203,67,176,134,195,81,98,18,218,56,206,28,90,16,20,34,179,96,67,71,111,101,193,146,120,154,28,180,54,182,138,22,192,221,38,63,33,80,217,134,29,223,155,2,65,166,53,88,150,181,200,140,40,112,11,52,143,210,34,164,84,155,15,81,251,236,33,121,166,117,182,75,150,149,172,55,203,109,209,185,105,132,119,36,206,13,81,86,52,158,161,18,229,226,135,239,242,181,245,120,248,20,251,33,29,59,194,213,88,194,29,128,112,8,254,203,37,222,56,147,59,202,238,195,102,19,237,83,24,182,212,20,254,127,137,206,97,8,86,2,170,192,187,228,250,86,237,247,97,198,44,118,182,214,97,247,92,142,94,231,3,39,241,134,142,138,156,19,165,89,145,171,160,159,90,42,246,81,58,190,128,206,245,158,251,24,113,42,113,173,155,43,157,231,133,242,131,164,66,226,254,14,196,165,160,154,173,173,109,209,86,102,120,85,97,34,170,227,24,69,51,131,236,215,96,71,188,195,129,246,68,16,229,191,111,127,219,244,242,119,186,167,55,255,251,3,203,159,215,51,249,8,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c7f3f3bd-75f9-4e4a-b48b-87077553380b"));
		}

		#endregion

	}

	#endregion

}

