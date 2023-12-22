﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: RelationshipDesignerDataMigratorSchema

	/// <exclude/>
	public class RelationshipDesignerDataMigratorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public RelationshipDesignerDataMigratorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public RelationshipDesignerDataMigratorSchema(RelationshipDesignerDataMigratorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("71a1c39c-5da2-2b60-7311-73546c6cca37");
			Name = "RelationshipDesignerDataMigrator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("330585ef-45a9-4680-b6b8-7296ad2a3590");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,61,219,114,220,54,178,207,218,170,253,7,122,206,214,214,76,149,66,95,78,206,94,172,72,46,205,72,114,116,214,183,149,148,228,33,149,114,209,51,144,196,99,14,57,38,57,118,38,142,254,253,224,142,6,208,32,193,25,57,181,15,206,67,172,33,209,23,52,128,238,70,119,3,44,179,37,105,86,217,156,36,87,164,174,179,166,186,110,211,89,85,94,231,55,235,58,107,243,170,76,47,72,193,255,104,110,243,213,9,105,242,155,146,212,127,254,211,231,63,255,105,111,221,228,229,77,114,185,105,90,178,60,112,126,83,36,69,65,230,28,48,125,78,40,76,62,247,218,156,100,109,150,94,126,40,102,69,78,202,214,123,253,34,47,63,120,15,175,110,107,146,45,232,131,244,42,107,222,55,230,61,228,127,185,172,74,252,77,77,66,207,211,147,105,240,213,89,54,111,171,58,39,1,114,180,197,105,217,230,173,213,224,166,168,222,101,197,211,167,130,155,244,69,117,115,67,31,155,247,63,172,22,89,75,146,67,159,141,84,188,162,77,105,227,255,170,201,13,21,98,114,94,182,164,190,166,3,245,52,57,199,134,132,201,242,101,126,67,7,173,170,57,224,195,135,15,147,239,154,245,114,153,213,155,35,249,59,87,72,250,113,164,10,197,67,128,99,0,60,109,205,230,200,222,199,42,95,36,151,109,86,183,226,13,5,25,79,68,215,238,68,7,73,185,16,125,180,250,59,43,178,166,121,154,88,100,40,250,96,215,120,123,175,57,218,139,213,250,93,145,207,147,57,10,33,248,102,156,43,78,206,114,82,44,40,43,111,234,252,35,29,22,241,114,37,126,48,137,38,111,75,66,22,23,228,35,169,91,53,13,232,176,62,62,144,104,236,254,105,180,111,234,106,69,33,104,99,138,154,115,36,222,187,157,227,15,142,231,243,106,93,182,199,231,139,84,183,129,93,82,125,122,190,166,210,54,141,19,62,4,123,55,164,61,72,26,194,87,152,148,122,39,153,233,16,50,211,225,100,168,130,105,233,138,138,235,141,105,188,37,153,184,222,152,198,67,201,168,25,116,181,89,145,40,82,54,192,112,114,116,162,53,100,11,170,8,220,80,226,111,170,38,231,86,161,147,30,91,20,170,229,80,10,84,151,204,235,124,213,79,164,105,107,166,70,65,251,45,230,71,41,76,84,180,16,93,144,14,146,161,117,255,146,180,183,85,80,159,188,171,170,34,57,171,106,185,184,46,200,188,170,23,199,227,137,36,84,147,118,93,151,201,3,160,15,78,63,172,179,162,25,51,246,210,211,229,170,221,76,32,23,157,120,167,33,188,211,94,188,253,189,235,83,105,23,130,100,205,57,73,142,35,132,255,156,132,228,129,9,236,25,212,131,79,129,26,137,88,97,144,179,233,16,206,60,137,98,34,127,6,85,231,83,160,121,134,113,214,36,89,146,149,139,72,62,249,64,238,115,118,39,140,95,110,169,54,130,169,198,229,90,47,222,195,67,212,186,61,163,232,64,151,247,173,161,153,208,62,141,225,131,125,75,62,147,248,94,10,77,149,180,116,169,197,14,130,81,110,195,251,132,107,200,167,142,190,238,87,43,183,100,254,62,201,175,19,194,69,156,80,214,8,95,75,234,65,150,84,181,250,251,93,160,99,252,201,42,171,179,101,82,82,23,253,112,36,218,159,47,70,71,234,175,244,187,135,188,1,20,4,95,230,223,103,141,144,182,212,86,100,193,7,63,81,128,74,48,31,51,201,134,112,88,252,73,113,0,229,167,160,153,252,20,84,122,78,93,242,199,201,239,191,135,223,62,233,149,23,165,155,204,21,167,114,54,15,151,10,38,13,53,45,180,28,68,207,112,105,88,11,228,94,196,242,204,145,4,157,74,118,139,14,133,218,239,27,91,158,171,177,75,3,157,100,27,112,152,187,236,18,117,29,231,65,30,110,148,249,29,238,176,136,161,139,243,52,117,219,237,136,196,249,153,186,237,127,184,155,201,182,173,116,182,70,249,96,178,237,78,206,80,223,252,208,90,85,25,63,169,83,231,235,186,102,180,59,245,6,212,142,192,175,145,64,199,98,213,203,95,83,199,110,152,25,36,33,37,208,36,249,235,95,193,200,91,47,41,142,223,127,231,72,246,2,224,211,46,240,227,160,171,21,181,103,62,201,51,186,211,94,158,213,213,82,234,172,30,133,32,1,26,101,11,167,235,188,88,16,60,4,96,105,131,0,160,175,10,58,247,208,47,242,166,253,142,141,192,81,242,246,99,78,173,52,89,192,112,138,110,247,239,53,89,19,213,80,232,93,254,168,103,163,77,213,20,157,167,107,22,193,137,154,104,166,121,172,21,154,107,69,216,48,77,136,27,163,128,172,198,188,247,110,20,226,40,113,112,170,73,57,179,31,83,251,228,52,140,89,117,150,98,14,142,136,207,147,75,60,188,222,145,161,253,209,30,89,3,156,28,250,227,158,60,163,46,166,247,240,48,41,201,39,128,83,57,147,123,77,0,203,97,242,49,43,248,4,241,56,131,147,233,212,204,37,142,6,204,45,193,8,124,32,152,0,224,130,11,136,251,36,231,66,162,243,229,59,225,84,24,150,53,246,243,82,78,136,131,104,200,83,27,16,176,106,158,1,118,65,67,206,114,23,110,191,15,98,187,43,148,171,208,34,247,190,215,5,147,131,58,89,63,148,249,135,53,81,67,167,189,119,208,104,205,91,48,207,137,141,172,51,25,133,182,77,143,155,55,116,225,21,5,41,198,19,249,232,146,176,64,244,216,172,19,38,56,243,43,181,246,46,18,230,132,82,205,75,10,165,30,92,85,140,17,229,251,225,76,61,249,34,92,77,13,87,63,221,146,154,80,27,81,176,182,15,0,229,148,239,33,243,146,25,144,34,182,19,16,254,120,177,184,200,202,27,50,134,221,177,29,93,240,166,103,165,67,143,155,183,199,29,110,137,55,90,98,170,247,115,214,123,250,79,138,236,115,52,13,92,204,130,31,32,105,241,32,69,246,8,214,212,119,70,192,195,246,192,81,110,102,60,172,166,19,116,32,28,65,242,128,57,29,15,177,218,175,42,174,105,198,64,188,22,202,6,110,230,174,215,229,130,44,108,217,27,11,33,31,244,9,216,239,28,80,143,125,29,51,83,78,204,29,140,163,244,172,170,79,179,249,173,79,233,51,116,153,4,189,211,242,3,239,191,77,78,32,191,11,203,239,121,93,173,87,212,53,213,198,118,163,204,47,148,164,218,141,41,25,126,186,205,11,146,140,245,38,237,184,220,176,112,134,100,139,73,56,231,156,154,109,220,89,94,55,237,235,250,132,92,103,235,66,247,154,55,189,97,44,168,33,96,250,151,78,215,219,75,162,104,127,22,184,238,14,194,125,206,77,87,21,107,176,153,205,221,158,173,171,15,161,81,75,79,136,192,168,176,113,6,231,238,60,241,215,173,189,8,20,48,117,194,237,241,112,37,181,183,231,205,95,103,210,42,84,123,70,74,70,7,5,218,222,201,127,221,181,70,225,112,70,239,160,104,181,53,228,237,121,84,243,21,249,196,254,101,1,42,192,134,90,155,10,203,172,32,89,121,86,209,137,204,158,51,21,165,39,136,154,135,161,89,136,128,118,204,62,183,95,106,153,124,228,78,137,158,114,23,100,89,125,36,244,169,226,208,119,9,183,83,169,97,37,198,148,173,29,225,163,123,151,200,230,204,124,225,246,199,117,8,125,239,238,126,119,144,220,225,110,146,133,84,4,38,198,179,144,145,143,240,198,177,211,45,227,120,199,225,160,154,235,216,136,222,119,104,40,103,122,89,251,80,219,109,220,54,118,228,228,85,135,164,144,145,60,107,108,246,248,103,169,38,167,121,201,18,248,99,22,215,173,174,199,189,169,228,201,228,23,119,227,217,7,146,68,101,201,7,237,82,89,217,65,85,22,155,228,252,69,117,147,188,45,232,255,14,19,250,231,203,172,204,110,232,102,153,142,52,203,241,211,29,221,168,143,242,104,98,57,253,60,135,60,191,93,151,239,47,243,223,216,6,227,241,163,71,143,14,80,218,188,41,93,99,116,247,246,50,251,149,173,231,37,105,73,221,204,88,58,129,66,62,113,33,101,132,230,237,92,36,25,46,231,183,100,153,189,162,80,180,241,72,102,30,70,40,68,38,114,20,54,132,76,92,140,112,238,184,155,247,86,197,237,237,92,25,213,102,203,140,58,174,232,208,241,61,119,86,182,77,10,131,86,54,130,183,2,195,112,202,175,170,118,119,226,26,73,12,125,149,106,56,201,169,42,108,163,201,42,176,183,2,110,8,165,239,171,58,255,141,141,102,124,39,53,53,3,219,69,177,37,243,219,50,159,103,5,20,146,212,217,220,138,142,30,205,254,241,248,159,255,120,114,246,205,236,239,143,255,246,205,183,199,179,111,191,249,231,201,163,233,55,127,63,62,249,246,127,78,254,54,155,29,79,255,219,153,249,154,6,215,167,98,230,29,153,222,137,32,115,177,94,150,108,254,89,22,66,181,21,74,119,36,108,205,249,98,180,159,140,196,140,253,129,254,224,42,242,143,142,14,73,61,213,167,3,198,63,52,124,84,212,238,111,109,253,156,48,131,220,222,230,77,234,52,59,116,26,14,41,50,193,180,154,131,222,249,217,31,224,129,149,32,90,240,140,121,27,147,168,143,218,136,22,64,99,158,243,89,57,39,211,13,27,225,177,175,116,38,233,15,60,229,230,135,38,160,66,219,137,166,167,26,49,154,76,241,206,180,138,182,99,87,90,117,155,96,148,116,132,153,167,204,35,80,201,81,242,200,184,199,150,178,55,17,42,229,177,66,127,114,187,200,138,212,225,220,36,209,37,155,255,150,189,43,200,37,127,56,150,239,106,210,84,235,122,78,120,135,129,239,82,184,0,148,197,191,140,60,52,77,250,25,98,184,75,127,100,221,24,73,9,104,18,212,218,171,85,235,49,226,140,214,133,68,119,73,23,7,29,170,125,33,17,218,5,145,204,77,25,153,125,159,61,219,73,18,36,177,137,202,6,80,12,62,93,15,122,36,199,236,177,176,167,142,49,117,162,20,97,163,251,16,135,199,120,0,110,164,16,145,72,60,28,193,212,181,209,121,47,179,21,115,16,221,60,182,19,202,179,17,201,25,246,89,91,234,99,174,19,189,5,122,183,239,54,156,246,54,52,21,20,180,161,183,252,252,134,211,64,67,49,199,49,249,136,96,141,43,13,25,194,65,196,32,223,216,19,73,109,54,132,16,109,103,76,38,99,164,104,152,177,160,60,78,232,206,104,12,229,21,141,97,138,97,152,70,97,80,194,180,48,0,9,71,99,152,98,24,250,120,96,48,118,122,48,162,57,82,28,209,11,5,170,179,130,109,25,42,229,140,48,24,161,73,186,90,67,246,221,138,44,41,136,240,107,137,151,101,199,194,66,225,191,85,211,115,138,162,254,223,42,119,185,176,41,201,71,175,17,94,57,87,231,13,207,241,69,15,68,128,170,150,148,79,29,188,114,185,128,242,197,185,81,188,170,150,128,147,23,228,186,125,189,110,93,110,204,84,116,120,65,86,154,205,17,190,20,181,15,215,33,43,100,149,238,204,221,180,143,187,233,64,238,166,247,194,157,214,16,33,238,160,10,137,225,14,209,46,59,115,23,150,29,84,79,3,184,131,178,19,209,41,68,202,109,254,145,0,92,66,69,164,218,0,143,169,131,78,38,147,36,107,164,133,24,106,107,232,78,111,70,183,38,173,8,218,108,148,203,52,215,91,17,89,48,208,40,163,22,109,155,64,128,60,189,170,86,99,237,136,244,40,82,67,218,105,40,251,206,183,37,99,195,143,24,54,179,19,218,66,235,237,40,125,233,234,166,199,229,162,171,55,41,221,88,143,25,178,87,235,66,199,37,5,148,122,119,250,43,149,89,51,86,17,227,62,195,223,105,52,149,254,211,77,125,129,244,76,124,0,139,75,8,118,14,157,237,134,19,179,46,204,92,21,216,147,158,217,43,220,88,124,14,171,64,33,107,241,239,53,169,55,99,217,14,110,171,249,11,100,218,66,196,1,199,234,188,108,171,46,201,164,151,164,29,135,246,240,112,34,74,42,62,91,88,143,221,106,132,68,172,208,112,61,218,24,30,50,58,103,255,191,32,217,130,212,60,232,64,106,164,239,30,9,233,77,131,58,226,67,9,45,50,134,172,87,220,91,145,1,107,203,60,237,91,192,211,104,224,41,0,6,103,31,122,128,161,114,183,129,35,40,67,221,43,129,157,226,177,30,4,174,11,163,145,96,5,181,189,184,80,71,83,162,52,85,188,1,44,116,67,71,145,72,31,82,2,193,51,2,33,56,25,80,26,219,46,171,17,165,93,246,31,41,143,128,247,137,110,126,2,53,55,222,214,16,206,113,145,78,1,187,247,186,179,41,12,160,121,148,84,98,194,69,35,149,199,97,104,91,166,246,223,238,27,170,183,201,124,205,86,40,19,212,120,172,150,157,201,243,66,74,54,179,44,135,213,183,188,37,190,3,136,139,231,167,248,224,96,88,173,28,150,7,55,141,128,155,106,56,22,217,145,244,152,150,103,231,35,198,172,232,79,33,51,15,77,216,71,168,26,59,57,217,61,96,60,87,137,51,101,231,192,77,252,163,11,93,48,93,222,37,236,102,124,126,90,174,151,164,102,49,23,100,130,66,146,58,151,25,12,171,80,33,127,123,224,52,153,129,104,24,26,162,193,194,51,102,178,174,178,186,109,192,224,113,70,210,203,85,145,183,175,75,142,166,25,59,132,36,52,135,212,121,86,246,203,153,157,160,182,78,112,37,87,144,248,225,57,119,190,101,52,111,71,106,230,92,87,84,216,243,91,22,24,180,23,26,149,6,239,139,153,48,58,151,168,106,207,157,94,166,161,218,116,197,189,40,203,117,128,224,9,43,225,119,189,174,213,4,126,38,67,135,226,196,79,242,52,8,169,232,120,18,18,129,192,102,108,220,36,230,14,96,155,43,25,30,114,188,71,171,191,162,76,126,210,139,107,26,139,235,73,8,151,212,207,8,18,87,224,246,25,19,23,159,44,133,198,16,201,225,152,56,229,9,160,154,2,72,17,24,149,134,141,82,213,122,234,164,173,55,166,224,194,199,32,213,175,153,18,119,201,60,107,217,196,187,252,80,156,254,58,39,194,30,18,80,181,193,146,154,233,105,93,87,53,207,117,209,238,240,31,137,40,62,153,51,37,193,246,65,248,4,127,154,124,126,116,71,251,77,232,198,70,70,120,39,110,237,198,29,212,89,225,224,168,159,99,167,114,119,235,103,67,133,179,184,10,212,154,41,80,134,171,203,2,220,231,170,118,18,47,222,13,17,179,148,114,0,117,42,11,7,34,181,50,133,214,201,255,113,167,176,120,49,139,238,176,248,101,85,127,104,149,199,223,5,44,50,168,203,224,205,196,194,86,69,49,156,53,197,141,120,255,47,178,81,227,45,166,224,133,131,201,176,239,210,144,5,56,0,69,71,109,87,31,114,80,98,227,211,225,251,118,57,32,102,223,222,101,174,158,124,97,115,165,235,103,238,197,98,17,87,28,195,237,22,156,104,184,213,210,103,158,60,139,21,32,31,109,20,186,244,184,169,234,196,224,21,61,20,129,25,112,68,249,134,120,30,170,130,67,120,190,188,34,134,35,54,80,13,119,235,30,181,164,240,85,195,11,34,121,31,237,66,115,124,150,5,163,7,122,170,129,240,193,40,114,28,45,242,142,164,177,110,93,213,235,146,10,159,92,49,103,86,197,245,26,147,249,149,61,3,227,202,181,63,221,208,80,180,120,184,73,132,144,0,14,245,220,25,247,190,81,239,30,243,5,99,129,49,91,21,11,94,176,150,92,83,178,108,172,233,128,63,102,3,110,56,64,7,63,88,164,40,58,135,219,116,189,183,180,229,214,237,226,246,19,177,76,89,15,9,68,27,69,17,224,33,48,94,100,23,65,193,52,142,38,97,116,86,140,144,84,132,108,0,242,72,249,88,43,168,7,253,21,86,195,51,222,126,210,59,185,47,245,78,198,69,173,120,191,183,148,241,130,162,201,23,94,61,154,40,88,67,144,126,135,246,196,22,144,9,192,202,16,154,168,17,51,242,218,53,119,61,179,178,187,88,194,117,134,165,16,189,212,96,47,164,189,47,11,102,204,6,224,153,118,224,65,243,211,51,145,6,18,251,39,149,206,150,191,236,182,76,126,63,229,229,162,250,196,227,197,103,116,97,112,109,37,231,14,143,229,86,159,94,173,151,239,72,109,183,80,1,189,61,121,134,171,222,8,148,167,191,174,106,210,52,172,73,119,135,118,133,23,224,50,63,163,153,236,200,207,64,245,42,128,102,177,137,233,43,149,156,187,66,210,190,232,188,9,227,245,51,35,167,58,51,121,122,220,135,31,159,65,113,100,116,138,241,116,26,79,6,75,35,94,245,148,13,132,85,149,31,129,51,21,173,110,166,75,8,3,100,222,194,120,221,98,27,15,213,52,26,149,91,101,211,151,253,244,246,206,118,176,240,8,168,180,151,235,162,205,37,171,174,122,107,34,131,207,161,192,179,67,213,10,65,171,181,1,227,207,61,90,214,64,131,112,136,134,143,214,186,124,94,26,213,27,126,219,163,97,145,150,221,170,180,19,0,211,153,0,192,85,149,92,147,56,66,148,86,68,2,57,235,3,18,55,122,137,78,185,231,124,43,80,251,147,238,177,55,203,246,60,185,239,152,5,232,204,126,56,41,128,240,244,187,199,48,250,182,139,105,74,72,251,137,148,42,77,87,46,254,248,21,181,211,154,8,46,135,168,149,48,100,17,12,153,255,29,83,63,218,136,6,106,96,28,67,170,52,243,235,176,207,101,140,210,149,35,171,232,50,155,211,199,93,148,92,31,205,16,164,112,219,82,124,18,71,113,234,82,124,226,80,252,35,173,44,117,8,86,164,156,22,213,252,61,8,41,153,103,74,32,187,89,97,99,135,159,236,96,135,211,89,81,53,196,227,181,182,58,49,136,97,159,198,14,12,251,189,199,24,182,158,125,213,249,91,233,252,230,171,170,255,170,234,191,170,250,225,27,170,123,208,140,247,161,200,191,170,61,167,10,207,233,65,55,255,59,21,227,57,148,164,52,251,203,176,238,187,158,77,175,200,88,120,103,25,91,104,34,234,242,186,99,80,51,80,222,209,89,209,102,43,77,180,248,12,30,149,227,97,45,239,54,77,36,171,202,158,55,152,13,99,47,78,155,15,210,232,120,184,221,147,95,200,57,61,71,233,142,244,156,181,8,176,195,145,199,139,101,94,94,228,55,183,60,169,122,157,21,13,193,219,190,169,115,118,70,19,4,237,232,234,63,46,62,101,27,99,35,89,233,50,14,77,151,149,178,68,44,197,18,98,232,44,47,88,206,215,90,133,234,157,72,169,137,22,63,229,237,173,73,17,203,192,165,120,69,71,107,149,213,121,35,0,197,197,112,66,255,238,219,146,79,103,25,29,146,234,221,255,81,222,143,120,61,249,113,93,103,44,63,137,175,112,201,71,208,155,241,142,162,113,42,126,153,133,235,233,0,69,232,172,99,240,70,154,14,233,128,136,132,174,190,214,98,147,218,11,46,238,2,163,93,250,160,207,40,72,254,238,183,23,140,2,207,102,108,211,15,175,180,67,29,117,182,79,115,34,29,236,88,157,246,196,97,179,51,144,127,241,107,64,205,98,118,85,130,77,9,135,52,159,129,0,37,15,106,69,232,242,53,211,202,245,77,131,51,217,128,136,203,103,146,103,182,105,116,218,92,85,70,174,252,226,9,126,192,154,45,48,169,23,128,230,220,79,172,6,242,8,234,2,213,173,66,25,76,146,167,130,58,122,207,154,106,28,78,207,137,15,62,224,139,172,185,170,116,222,142,139,93,159,70,225,90,125,63,9,149,103,186,235,20,90,122,84,109,179,23,231,94,145,97,147,154,58,125,113,243,86,145,210,37,106,212,141,24,34,144,61,52,117,135,242,175,254,50,67,217,16,20,229,174,185,72,76,31,164,49,17,146,114,102,137,227,198,194,45,128,114,0,35,139,253,250,178,146,209,53,126,48,9,170,128,207,75,207,207,108,198,142,240,133,159,169,63,0,194,224,92,73,220,111,106,148,99,15,87,245,137,219,113,6,166,69,249,156,158,174,139,247,131,230,245,54,134,134,207,20,126,191,142,165,15,125,101,213,192,26,203,128,174,146,96,65,37,139,16,2,152,120,5,27,232,222,116,35,111,200,240,237,7,114,19,19,47,62,152,110,194,247,1,58,22,82,150,238,216,117,89,128,18,107,198,113,178,26,45,156,53,235,98,179,85,77,62,230,213,186,129,100,28,141,221,252,140,225,103,53,123,191,128,117,11,218,24,7,149,169,80,108,97,201,22,99,140,186,119,151,154,213,129,25,208,49,62,83,122,219,231,9,58,66,210,18,53,90,249,230,247,174,67,200,10,145,85,207,13,201,134,208,137,107,229,156,98,110,113,195,153,233,247,95,70,159,125,240,187,228,179,223,147,187,81,122,69,141,156,141,79,149,33,134,88,176,171,17,77,29,162,115,137,215,222,158,146,48,171,74,28,63,218,23,136,83,94,245,200,110,86,203,193,254,119,111,111,144,66,176,187,44,49,255,156,255,98,202,217,236,106,62,76,21,153,155,48,58,39,160,108,134,206,67,160,106,232,22,118,85,136,175,54,161,119,107,140,68,255,80,82,47,73,211,208,173,205,149,68,49,178,194,117,106,80,165,89,148,138,90,145,219,199,25,179,124,35,104,65,49,117,124,65,40,170,57,25,156,212,37,142,167,108,37,98,123,208,200,26,61,85,99,9,176,56,23,6,158,151,121,155,51,89,134,74,148,228,56,15,182,41,46,221,62,163,37,165,52,101,129,219,216,200,237,170,174,230,116,108,245,53,151,220,106,114,41,189,81,111,250,241,25,81,97,232,254,40,113,97,180,59,68,22,19,4,31,32,3,95,166,116,45,120,66,237,143,170,163,113,112,155,188,73,192,98,72,59,211,179,131,176,191,201,168,38,183,181,108,168,169,217,26,86,213,251,245,42,108,159,116,64,105,63,233,105,51,61,87,119,97,134,228,137,62,15,123,41,194,169,197,128,160,150,55,106,67,132,202,176,246,166,23,7,30,212,180,15,106,106,67,101,181,82,107,205,121,249,186,36,102,100,99,71,72,153,39,213,65,250,204,50,91,246,125,169,130,9,121,160,146,181,181,3,2,226,46,42,93,179,238,25,76,55,176,0,17,154,75,52,181,0,249,101,155,17,77,205,96,115,203,168,187,196,85,135,122,161,190,243,20,16,153,50,167,248,133,157,18,24,157,51,65,187,211,171,171,212,17,12,170,250,30,156,55,104,35,126,3,0,208,127,34,146,214,169,251,48,117,197,63,255,208,77,66,82,144,1,193,102,104,238,140,213,25,74,215,135,239,252,240,52,21,172,150,221,173,88,214,205,73,200,17,106,172,124,196,37,5,203,106,113,48,122,194,46,34,11,142,85,167,92,253,42,97,238,17,177,11,22,197,229,144,184,71,132,187,93,153,60,95,125,160,12,26,63,164,146,15,62,171,2,131,195,242,48,128,181,85,223,97,151,207,35,59,8,176,234,177,211,28,220,155,131,81,84,27,41,251,106,200,9,30,159,240,114,105,93,24,237,198,250,158,202,137,45,149,251,13,26,8,156,72,65,117,91,237,82,78,29,17,166,53,7,1,169,153,92,89,58,104,203,40,175,136,2,192,155,234,122,209,140,253,109,63,136,114,222,239,126,159,49,32,15,173,167,38,27,41,232,59,180,59,143,245,21,84,92,150,23,127,150,151,11,95,134,28,20,30,114,183,225,220,139,190,133,224,204,213,221,118,107,103,123,22,123,85,95,196,56,226,204,135,34,161,209,243,64,158,47,250,145,42,177,5,191,70,248,80,220,119,44,190,255,187,97,161,96,251,196,169,53,21,53,216,145,99,49,93,180,169,252,75,159,175,2,236,56,247,143,15,23,205,155,154,172,184,121,23,59,219,237,22,133,115,40,121,203,253,7,19,233,210,222,246,246,236,156,95,88,243,39,176,101,222,45,234,119,143,97,63,59,54,196,239,243,207,75,76,156,110,2,230,170,222,80,138,60,149,192,111,249,247,50,71,251,73,181,110,19,21,152,131,225,176,206,128,129,35,236,125,31,26,165,70,241,224,38,241,30,160,156,128,149,138,82,193,119,119,35,63,140,131,36,223,130,110,203,247,89,185,40,136,92,132,226,195,5,112,81,3,20,126,153,133,187,26,172,13,158,80,81,98,78,2,5,191,165,145,208,55,188,223,155,141,208,103,94,241,112,240,141,21,154,212,228,173,184,111,221,37,11,33,174,160,189,21,103,182,221,239,37,136,155,81,58,176,226,54,196,150,178,177,40,157,168,144,248,159,12,49,194,17,197,8,244,229,226,32,252,246,42,244,65,88,135,194,203,96,4,227,246,60,117,212,184,175,199,96,220,21,126,78,133,53,113,35,3,96,192,215,234,179,243,193,122,29,153,98,51,24,148,148,5,168,231,73,162,162,148,95,183,239,35,210,37,85,208,7,164,62,232,11,39,2,3,158,216,208,108,160,151,84,136,79,12,2,96,85,126,6,210,130,193,131,136,194,251,199,165,240,245,52,98,252,105,196,190,226,198,168,75,102,53,54,255,84,24,126,63,163,1,56,113,251,97,46,56,240,251,1,222,161,17,135,255,160,131,132,246,121,110,89,153,122,162,207,248,121,221,214,247,66,124,145,195,133,95,207,48,14,59,195,136,28,74,28,120,208,16,221,210,247,120,100,118,84,14,122,4,240,112,96,140,230,243,19,255,182,187,51,204,181,243,57,137,171,1,182,114,192,254,221,107,46,189,64,241,175,229,82,45,22,190,193,14,84,250,246,68,109,59,77,114,4,179,59,85,250,122,4,213,142,115,155,90,95,176,81,217,238,246,74,111,225,239,86,247,139,44,241,221,42,128,241,185,62,164,203,190,10,81,87,102,42,139,50,132,67,96,134,16,14,47,244,245,140,238,168,91,223,23,165,235,220,124,211,163,155,182,103,63,145,111,11,68,124,64,163,106,121,106,165,243,211,97,197,123,113,237,14,145,137,29,232,241,135,62,4,163,16,139,196,3,195,209,125,207,226,118,23,154,193,98,14,173,190,58,175,108,60,10,93,91,22,44,250,64,182,28,61,165,30,221,61,117,42,57,28,69,165,171,176,59,191,79,46,70,3,246,68,197,217,212,16,201,47,133,247,14,79,224,10,204,83,251,118,23,161,184,193,135,57,176,61,148,245,221,142,3,127,75,110,98,68,160,165,222,19,242,121,82,18,178,208,151,118,153,130,116,78,95,36,118,68,129,126,224,66,86,247,238,114,30,104,249,23,217,236,115,218,226,34,46,101,73,228,71,37,13,197,192,205,86,230,162,167,0,233,83,239,202,105,192,169,201,74,154,203,86,213,229,106,0,171,127,79,214,158,37,10,11,240,208,124,140,71,23,3,125,137,235,13,69,199,6,220,169,213,59,109,11,226,94,251,169,102,109,203,86,107,236,108,101,104,20,163,82,237,234,59,64,213,77,135,157,23,59,29,32,109,78,173,123,153,2,45,224,197,74,88,19,184,116,66,239,81,26,93,177,228,46,145,170,96,186,45,85,176,125,142,146,168,194,18,82,89,74,170,131,234,168,14,32,72,108,17,16,22,206,236,21,130,12,23,37,243,117,211,86,75,45,10,158,159,141,156,83,42,226,196,49,216,33,112,171,220,86,5,144,98,162,48,86,170,251,11,228,56,33,230,129,25,88,243,217,187,137,187,203,234,218,95,249,223,41,176,62,153,162,91,184,101,220,104,240,108,168,129,131,33,66,58,75,84,211,134,153,109,145,142,189,37,204,182,168,88,117,94,182,149,190,126,116,91,59,168,190,94,231,234,151,176,197,244,119,89,224,6,242,136,11,205,13,188,228,157,171,27,59,28,109,238,129,117,105,72,240,142,219,83,45,172,178,121,191,123,22,160,35,190,199,123,92,84,165,47,11,243,189,215,174,145,22,24,232,136,50,28,230,67,191,81,195,213,75,29,47,219,104,214,239,34,14,134,59,81,36,59,116,163,150,64,248,99,27,108,61,0,231,133,95,194,166,20,7,126,187,92,199,231,56,20,57,88,47,35,191,29,82,142,117,119,20,61,65,235,11,92,34,71,228,40,13,114,18,134,125,208,175,239,19,148,151,45,187,246,117,201,191,35,201,32,251,63,95,204,103,10,7,123,169,160,244,196,224,125,62,47,175,171,241,72,191,76,26,214,150,232,225,235,244,54,228,214,160,195,120,96,235,17,85,44,162,97,175,37,62,8,51,126,157,151,121,115,171,57,143,255,62,50,127,6,255,251,127,149,32,168,218,25,153,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateUpdateTechnicalRelationTypeMessageTemplateLocalizableString());
			LocalizableStrings.Add(CreateUpdateLoopConnectionMessageTemplateLocalizableString());
			LocalizableStrings.Add(CreateTechnicalRelationTypeCaptionLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateUpdateTechnicalRelationTypeMessageTemplateLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("3aa48da9-2334-4639-ac09-28d1d54f2e4d"),
				Name = "UpdateTechnicalRelationTypeMessageTemplate",
				CreatedInPackageId = new Guid("306bd3dc-c1db-4d7d-a14d-6d8f14db70cb"),
				CreatedInSchemaUId = new Guid("71a1c39c-5da2-2b60-7311-73546c6cca37"),
				ModifiedInSchemaUId = new Guid("71a1c39c-5da2-2b60-7311-73546c6cca37")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateUpdateLoopConnectionMessageTemplateLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("41062673-8b66-423d-b50e-784b65174f92"),
				Name = "UpdateLoopConnectionMessageTemplate",
				CreatedInPackageId = new Guid("330585ef-45a9-4680-b6b8-7296ad2a3590"),
				CreatedInSchemaUId = new Guid("71a1c39c-5da2-2b60-7311-73546c6cca37"),
				ModifiedInSchemaUId = new Guid("71a1c39c-5da2-2b60-7311-73546c6cca37")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateTechnicalRelationTypeCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("2e73cb10-93f4-de21-ebac-3fce7ab72a74"),
				Name = "TechnicalRelationTypeCaption",
				CreatedInPackageId = new Guid("330585ef-45a9-4680-b6b8-7296ad2a3590"),
				CreatedInSchemaUId = new Guid("71a1c39c-5da2-2b60-7311-73546c6cca37"),
				ModifiedInSchemaUId = new Guid("71a1c39c-5da2-2b60-7311-73546c6cca37")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("71a1c39c-5da2-2b60-7311-73546c6cca37"));
		}

		#endregion

	}

	#endregion

}

