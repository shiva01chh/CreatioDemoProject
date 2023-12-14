﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FileHandlerSchema

	/// <exclude/>
	public class FileHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FileHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FileHandlerSchema(FileHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7af3bdbd-6d12-458d-a43a-22d359322b7d");
			Name = "FileHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("cf33293c-a5ce-4503-a967-5e80eaa8edb4");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,84,77,111,219,48,12,61,187,64,255,3,225,1,69,122,177,239,75,19,32,8,214,174,135,97,197,186,156,7,197,166,19,1,178,36,72,114,135,44,232,127,31,37,43,243,87,210,96,185,56,162,30,201,167,247,40,73,86,163,213,172,64,248,137,198,48,171,42,151,173,149,172,248,174,49,204,113,37,179,71,46,240,43,147,165,64,115,123,115,188,189,73,26,203,229,238,67,248,70,11,197,202,249,89,172,193,75,241,236,139,116,220,113,180,4,32,200,39,131,59,42,8,107,193,172,253,12,3,26,180,157,231,57,60,216,166,174,153,57,44,227,250,7,106,131,22,165,179,80,248,44,168,148,129,125,155,4,21,21,200,78,137,121,47,83,55,91,193,139,152,49,104,147,28,67,171,142,138,146,214,153,166,112,202,16,163,151,144,215,34,198,108,66,96,109,144,57,180,192,64,226,111,224,148,203,36,9,173,42,112,123,36,56,34,20,6,171,69,218,107,154,230,75,112,7,29,152,78,169,182,17,205,12,171,65,146,115,139,180,177,104,136,150,196,194,171,159,46,55,180,134,226,95,32,123,200,3,58,36,199,131,246,186,205,54,131,116,24,86,187,7,111,119,146,140,64,139,17,204,251,153,188,71,165,80,150,173,88,67,229,94,140,210,104,188,185,164,155,225,111,164,75,11,208,237,2,182,74,9,248,197,237,179,164,17,96,130,255,193,242,145,212,107,12,82,119,207,120,165,249,124,154,80,157,193,92,244,227,9,105,48,104,34,172,255,190,49,209,32,25,193,28,57,83,242,34,56,229,125,137,37,33,157,244,79,129,28,116,151,172,25,16,235,146,162,134,59,116,241,95,194,43,152,93,57,233,73,249,36,49,72,59,242,252,65,253,254,123,251,137,176,39,161,182,76,172,180,126,69,231,232,134,217,236,188,136,49,205,118,164,166,13,200,231,160,81,108,116,133,49,161,233,102,96,175,250,127,77,132,114,52,75,88,94,51,175,25,77,247,37,39,98,57,24,77,238,104,121,4,114,101,14,87,136,126,67,183,87,229,148,101,215,37,56,78,252,214,76,118,130,204,194,107,118,120,45,246,88,51,192,222,226,100,110,244,172,167,225,221,221,0,152,81,205,103,187,162,55,195,210,139,243,189,154,133,135,34,189,255,224,194,181,209,97,48,196,252,239,47,115,27,78,54,236,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7af3bdbd-6d12-458d-a43a-22d359322b7d"));
		}

		#endregion

	}

	#endregion

}

