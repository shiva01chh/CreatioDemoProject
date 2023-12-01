﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FileCachedLoaderSchema

	/// <exclude/>
	public class FileCachedLoaderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FileCachedLoaderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FileCachedLoaderSchema(FileCachedLoaderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0aac963b-f451-42a5-90ea-6d83ad3a7c59");
			Name = "FileCachedLoader";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("3c624d29-361c-47f2-ac8f-7824eb3cde6f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,85,91,75,227,64,20,126,142,224,127,56,100,95,82,148,244,93,219,200,90,90,41,232,174,160,101,31,151,105,114,210,14,54,51,97,102,162,27,196,255,190,115,73,106,110,173,93,88,11,194,156,249,206,119,110,223,153,48,146,161,204,73,140,240,140,66,16,201,83,21,206,56,75,233,166,16,68,81,206,194,5,221,225,61,39,201,249,217,251,249,153,87,72,202,54,240,84,74,133,217,117,231,28,46,127,126,154,154,116,89,198,217,240,77,55,208,140,196,91,124,32,140,108,80,156,230,177,202,119,58,185,97,172,192,67,246,112,206,20,85,20,229,65,192,130,196,138,11,135,208,152,111,2,55,58,36,204,118,68,202,43,216,231,154,152,214,160,176,152,188,88,239,104,12,177,129,244,16,224,156,106,184,247,110,93,246,188,11,138,187,68,19,63,10,250,74,20,186,203,220,29,96,217,109,13,252,78,251,205,178,116,200,18,199,216,166,215,125,147,74,20,166,36,19,196,38,234,16,227,241,24,38,178,200,50,34,202,168,50,120,48,19,168,3,75,32,192,240,13,168,118,38,76,107,132,167,160,182,168,241,136,16,11,76,167,254,103,77,254,56,2,85,230,24,238,89,199,29,90,152,228,68,144,12,152,214,220,212,47,36,10,157,22,195,216,204,210,143,86,250,12,241,222,16,78,198,22,61,236,220,45,223,143,154,240,106,16,221,17,4,171,86,72,104,103,112,57,208,230,110,152,145,97,247,174,96,77,36,6,109,247,17,188,219,203,222,100,96,218,163,49,162,243,62,142,79,236,81,240,28,133,145,232,201,162,232,25,166,209,129,148,110,110,32,24,74,212,170,219,41,191,12,239,80,77,122,65,162,96,52,250,66,107,15,168,182,252,184,150,221,210,46,89,202,193,140,102,33,120,102,131,4,119,5,77,0,205,110,150,79,250,156,145,213,50,185,4,107,53,233,154,195,45,101,90,83,191,4,85,58,229,117,227,80,79,96,222,112,175,75,195,1,219,20,218,122,8,7,28,175,123,140,45,42,205,49,192,108,58,183,172,86,230,182,212,21,4,157,138,70,142,182,219,138,180,125,156,2,43,118,59,7,85,162,172,170,243,122,168,238,136,194,118,75,87,29,149,55,115,185,220,119,181,213,72,23,243,3,98,162,226,45,4,243,63,49,230,118,99,176,238,177,119,207,55,225,92,8,46,2,12,31,80,74,29,24,46,192,215,191,11,192,240,73,145,248,229,89,232,207,74,205,101,255,11,84,133,96,157,58,79,89,134,79,73,125,249,114,153,226,165,13,113,234,67,212,25,142,126,137,150,73,253,210,185,59,144,246,242,235,39,201,120,47,19,227,148,82,173,176,138,196,220,84,76,199,41,154,67,240,35,39,116,120,179,199,190,163,107,166,140,76,15,69,102,63,136,64,214,188,80,80,216,222,162,91,25,237,88,35,27,79,35,127,213,95,59,154,28,88,71,109,250,47,155,216,80,109,135,41,156,109,49,126,249,46,54,69,166,111,230,89,174,202,192,244,128,167,189,93,169,20,228,185,168,71,28,29,96,143,111,38,212,246,250,161,215,170,118,106,165,253,111,194,247,107,62,160,18,208,100,114,85,201,191,90,136,58,19,181,21,252,109,96,15,218,123,218,235,245,224,106,234,167,187,42,79,127,130,194,253,180,78,115,62,178,106,206,218,54,90,155,254,251,11,158,159,80,80,36,10,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0aac963b-f451-42a5-90ea-6d83ad3a7c59"));
		}

		#endregion

	}

	#endregion

}
