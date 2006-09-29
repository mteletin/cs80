using System;
using System.Collections.Generic;
using System.Text;

namespace CS80.cpm {


/**
 * $Id: DPB.cs,v 1.0 2006/09/16 Elfic.one 
 *  
 * DPB.java,v 1.2 2004/06/20 16:26:45 mviara Exp $
 * 
 * Abstract class to rappresent a CPM Disk Parameter Block for one
 * detailed description see static field.
 *
 * 
 */
public abstract class DPB
{
	
	public const int SPT = 0;
	public const int BSM = 2;
	public const int BLM = 3;
	public const int EXM = 4;
	public const int DSM = 5;
	public const int DRM = 7;
	public const int AL0 = 9;
	public const int AL1 = 10;
	public const int OFF = 13;
	
	public int sectorTrack;			// Sector for track
	public int bsm;					
	public int blm;
	public int exm =0;
	public int dsm;
	public int drm;
	public int alloc0;
	public int alloc1;
	public int trackOffset;
	public int[] translate = null;
	
	DPB()
	{
	}
	
	DPB(int sectorTrack)
	{
		this.sectorTrack = sectorTrack;
		setSkew(1);
	}
	
	public void setSkew(int skew)
	{
		translate = new int[sectorTrack];
		int sector = 1;

		for (int i = 0 ; i < sectorTrack ; i++)
		{
			translate[i] = sector;
			sector += skew;
			if (sector > sectorTrack)
				sector -= sectorTrack;
		}
	}

	void setTranslation(int s1,int s2)
	{
		translate[s1-1] = s2;
	}
	
	public int translateSector(int sector)
	{
		return translate[sector-1];
	}

	public void dump()
	{
		Console.WriteLine(this.ToString());
		Console.WriteLine("BLM (Block size/128 -1) "+blm);
		Console.WriteLine("DSM "+dsm);
		Console.WriteLine("TrackOffset "+trackOffset);
		Console.WriteLine("Sector track "+sectorTrack);
		Console.WriteLine("AL0 "+alloc0);
		Console.WriteLine("AL1 "+alloc1);
		Console.WriteLine("EXM " + exm);
	}
}
}
