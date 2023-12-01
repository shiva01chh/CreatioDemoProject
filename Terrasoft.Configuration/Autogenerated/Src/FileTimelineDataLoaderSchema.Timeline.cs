﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FileTimelineDataLoaderSchema

	/// <exclude/>
	public class FileTimelineDataLoaderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FileTimelineDataLoaderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FileTimelineDataLoaderSchema(FileTimelineDataLoaderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0e1344f7-2bc8-4e0c-97e6-e13bafa5bbce");
			Name = "FileTimelineDataLoader";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("0f0b57ce-3155-4876-a7bb-8a901e434b75");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,85,77,79,219,64,16,61,27,137,255,48,117,47,142,138,156,59,33,145,160,64,133,4,21,34,180,151,170,170,182,246,36,172,100,239,134,253,160,138,34,254,123,103,189,187,198,54,14,180,185,56,158,125,111,230,205,199,142,5,171,81,111,88,129,112,143,74,49,45,87,38,255,44,197,138,175,173,98,134,75,145,223,243,26,43,46,240,240,96,119,120,144,88,205,197,26,150,91,109,176,38,96,85,97,225,80,58,255,130,2,21,47,102,45,166,235,79,225,62,123,126,33,12,55,28,245,94,192,37,43,140,84,30,65,152,143,10,215,20,16,46,121,133,81,218,57,51,236,90,178,18,85,3,153,78,167,112,162,109,93,51,181,93,132,247,8,133,146,176,80,53,96,88,73,213,248,201,35,105,218,97,253,56,199,21,179,149,57,227,162,36,89,153,217,110,80,174,178,171,215,65,39,71,240,149,202,8,115,72,169,48,206,97,58,249,73,30,54,246,119,197,11,40,42,166,245,30,189,112,12,35,14,137,187,107,50,105,179,165,150,104,163,172,171,132,62,134,219,198,177,71,132,32,227,238,179,111,26,21,113,133,239,18,216,222,235,4,92,71,147,100,0,154,15,96,174,51,201,115,208,131,162,244,146,250,250,110,149,220,160,114,125,28,168,83,252,137,25,28,75,18,126,161,126,124,109,158,117,146,26,99,93,140,145,66,34,107,52,225,95,194,87,144,141,7,128,249,28,132,173,170,152,125,146,236,195,129,192,63,227,241,6,117,157,204,188,167,103,255,80,104,172,18,111,229,23,144,218,233,5,79,218,43,226,137,85,22,59,172,255,233,132,146,134,20,98,25,155,17,94,97,208,241,193,235,14,168,144,51,120,39,208,13,154,7,89,14,250,61,188,122,141,193,165,162,7,55,208,93,189,85,184,122,175,239,158,183,108,152,98,53,8,186,90,243,20,221,154,216,166,11,255,204,79,166,205,225,56,182,104,246,87,186,104,35,186,235,14,222,218,99,134,49,187,230,218,156,156,73,43,202,200,104,150,210,118,209,40,119,205,200,226,65,131,242,167,224,165,28,181,137,221,225,163,69,109,252,246,12,225,226,144,5,217,55,140,246,166,242,124,90,158,182,22,113,113,220,97,33,85,121,85,166,179,46,62,186,166,219,109,218,137,28,24,119,48,230,105,89,60,96,205,156,45,61,242,3,230,81,223,221,52,17,44,84,163,43,232,133,210,50,106,170,21,215,82,220,211,238,35,82,198,133,153,248,176,253,179,252,226,209,178,202,207,168,79,224,137,41,80,168,105,127,18,111,244,14,229,109,113,99,33,67,201,188,3,119,129,251,115,153,119,101,222,48,193,214,228,228,146,182,243,21,125,139,206,182,78,120,246,102,90,240,9,82,191,157,225,195,96,7,120,169,249,105,89,222,49,177,198,236,29,197,221,54,116,71,34,110,148,78,204,119,74,221,106,10,53,79,58,238,2,63,204,194,224,32,226,247,142,212,191,116,56,89,74,101,122,172,16,172,111,143,104,111,209,47,176,96,136,231,167,150,86,130,26,243,55,60,137,12,170,38,142,225,251,246,136,246,163,215,137,31,12,97,251,182,19,52,233,46,217,176,141,125,135,223,248,150,121,107,223,248,12,180,157,233,247,23,83,226,58,101,38,9,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0e1344f7-2bc8-4e0c-97e6-e13bafa5bbce"));
		}

		#endregion

	}

	#endregion

}
