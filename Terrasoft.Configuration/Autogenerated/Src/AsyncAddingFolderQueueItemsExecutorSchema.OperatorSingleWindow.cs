﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AsyncAddingFolderQueueItemsExecutorSchema

	/// <exclude/>
	public class AsyncAddingFolderQueueItemsExecutorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AsyncAddingFolderQueueItemsExecutorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AsyncAddingFolderQueueItemsExecutorSchema(AsyncAddingFolderQueueItemsExecutorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c3056242-aee3-4086-bba3-37eac3bd1a5c");
			Name = "AsyncAddingFolderQueueItemsExecutor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("a8569787-b88e-4075-aa85-f8031253bd51");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,83,201,110,219,48,16,61,59,64,254,97,160,30,42,3,134,116,111,100,1,70,106,7,46,218,52,109,234,94,138,30,104,105,100,51,144,72,149,139,19,35,200,191,103,72,45,182,85,7,136,14,2,103,123,124,111,56,35,88,133,186,102,25,194,47,84,138,105,89,152,232,90,138,130,111,172,98,134,75,113,121,241,124,121,49,178,154,139,13,220,239,181,193,234,106,96,83,126,89,98,230,146,117,116,131,2,21,207,14,57,199,176,85,37,197,249,136,194,183,252,209,130,101,70,42,142,154,50,40,231,131,194,13,221,4,215,37,211,26,62,193,76,239,69,54,203,115,170,92,200,50,71,245,195,162,197,37,241,210,243,39,204,44,213,250,186,56,142,33,209,182,170,152,218,167,173,253,19,107,133,26,133,209,192,128,57,160,173,146,66,90,50,61,32,252,115,88,192,29,24,20,82,129,70,39,20,115,216,40,105,107,13,15,114,29,117,216,241,17,120,109,215,37,207,32,243,28,223,193,144,116,44,191,200,117,111,62,123,202,189,214,111,104,182,50,119,106,239,60,112,19,29,42,242,142,6,2,29,51,144,197,59,117,68,61,92,60,196,75,106,166,88,5,130,198,100,26,88,141,138,134,67,52,143,29,164,43,178,33,235,29,81,18,251,236,243,197,254,140,6,149,14,210,187,254,124,82,211,182,109,199,149,177,172,132,157,228,121,39,40,92,157,220,13,167,84,38,176,252,204,253,137,184,39,218,40,18,61,1,185,126,160,112,10,135,155,199,174,179,163,209,136,23,16,30,188,48,157,130,176,101,217,69,71,134,198,224,17,4,62,194,76,109,108,69,3,114,75,225,239,106,94,213,102,63,127,202,176,118,87,133,71,146,32,99,226,163,129,53,122,160,96,124,229,129,94,252,191,161,3,132,194,205,254,62,219,98,197,110,169,12,166,71,196,104,111,204,111,86,90,12,131,97,94,48,129,6,33,242,215,183,208,95,185,54,73,39,176,240,99,181,164,9,57,139,153,28,39,167,97,208,167,19,180,215,221,64,222,88,106,183,159,148,101,254,22,185,54,76,133,46,251,132,209,142,169,150,200,202,240,146,27,218,88,66,241,107,218,172,240,222,225,36,126,248,245,226,52,49,13,169,217,127,254,118,253,119,157,167,199,37,217,214,21,118,143,16,14,7,112,50,24,131,113,211,245,150,208,128,76,68,43,120,216,188,176,111,194,228,191,151,153,116,93,104,128,94,218,101,68,145,55,251,232,237,198,123,234,36,159,251,94,1,121,19,176,65,84,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c3056242-aee3-4086-bba3-37eac3bd1a5c"));
		}

		#endregion

	}

	#endregion

}

