﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IndexerFactorySchema

	/// <exclude/>
	public class IndexerFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IndexerFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IndexerFactorySchema(IndexerFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7dd97aab-f6c9-494a-bc55-6550dca89127");
			Name = "IndexerFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("3c3a921b-299a-4f38-a040-5c0154a25bee");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,189,86,235,106,219,48,20,254,237,64,223,65,116,80,92,24,122,128,165,105,200,114,35,176,142,174,105,246,119,40,246,113,34,38,203,158,36,135,153,146,119,159,46,118,106,59,86,74,25,91,18,72,116,110,223,119,46,58,14,39,41,200,156,68,128,158,65,8,34,179,68,225,105,198,19,186,43,4,81,52,227,120,201,178,45,97,107,32,34,218,95,13,94,174,6,65,33,41,223,161,117,41,21,164,195,206,25,127,161,252,215,171,176,25,84,0,158,115,69,21,5,233,53,88,144,72,101,194,99,209,100,130,87,60,134,223,90,111,12,245,231,131,128,157,102,139,166,140,72,249,9,89,45,8,23,174,188,26,104,139,188,216,50,26,161,200,24,156,233,131,23,107,115,10,179,160,192,98,29,231,81,208,3,81,224,148,185,59,32,1,36,206,56,43,209,228,64,40,35,91,6,53,153,58,63,244,131,248,84,195,10,8,120,236,176,218,192,186,246,82,137,194,208,50,240,150,115,133,238,248,183,153,135,126,10,94,6,183,200,52,49,8,252,28,209,200,239,109,234,29,28,47,39,241,0,106,159,121,203,183,205,50,134,150,160,86,242,9,8,83,16,219,208,229,43,144,129,141,67,39,69,96,191,106,206,2,84,33,120,37,196,27,9,66,23,140,67,228,38,213,196,92,0,209,38,80,71,185,110,14,205,19,48,114,134,119,125,219,76,169,69,114,186,135,232,231,74,234,44,82,34,202,105,198,138,148,79,247,132,239,186,244,62,34,119,156,36,10,196,252,160,133,19,177,147,149,178,45,172,51,57,16,129,210,44,166,9,133,216,69,254,78,88,97,106,111,213,65,159,239,24,63,244,121,140,199,26,190,72,65,152,148,241,60,205,85,121,231,248,52,204,238,67,151,167,5,206,93,70,51,42,115,70,42,171,13,141,117,223,117,13,31,251,149,97,213,9,23,133,38,40,244,70,25,33,94,48,86,103,90,55,45,33,76,130,243,62,54,155,217,87,5,60,225,101,24,89,1,26,221,35,247,11,59,11,188,89,89,12,15,124,111,59,151,5,141,199,151,146,235,157,54,83,42,39,89,71,123,72,137,174,79,53,121,238,60,236,181,234,131,56,121,58,19,220,103,51,60,159,112,127,192,177,169,130,119,112,237,77,168,7,124,6,74,223,229,80,175,21,179,78,165,13,249,85,175,253,206,157,242,175,3,236,34,24,31,105,30,14,250,192,101,216,8,244,190,157,112,190,211,62,19,9,213,94,51,212,23,153,88,113,125,181,85,127,87,204,232,245,37,216,106,141,229,213,157,64,251,112,168,54,167,217,22,119,206,179,130,62,221,144,214,116,158,249,52,200,214,30,199,55,178,217,228,177,110,205,95,175,140,255,148,248,9,230,226,122,174,123,114,115,227,144,46,237,202,58,227,222,228,222,228,250,173,0,253,143,32,254,231,93,154,1,3,221,165,206,181,120,71,228,206,232,59,105,91,232,222,90,163,95,127,0,209,219,241,106,123,9,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7dd97aab-f6c9-494a-bc55-6550dca89127"));
		}

		#endregion

	}

	#endregion

}
