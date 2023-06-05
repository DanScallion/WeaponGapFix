# WeaponGapFix

HOW DOES THIS WORK?
Weapon gap happened because every time you crafted weapon it changed its scale to scale you choose and then changed spacing between parts, then again it changed it back to 100 overwriting it. I removed that line by using harmony transpiler to ignore that instruction at runtime. 
It also fixes bug that broke weapon crafting history which resulted in your "previiously crafter" weapons to not save weapon size data. It also fixes bug that caused weapons to revert to default 100% on game/save reload.

IT WILL NOT FIX PREVIOUSLY CRAFTED WEAPONS! WEAPONS BUILD WITH THE PATCH WILL RETAIN THEIR FIX.

Several parts still have weapon gap due to broken meshes or incorrect xml length. If you see part like that, or levitating/clipping pommel/other part. Post it in the comment and I will fix it once I get to the cause.

![image description](https://i.imgur.com/4ypHWzA.gif)

Load at the end of load order as other mods could overwrite xml edits otherwise. My edits do not alter blade data, so no damage changes, no flags or materials changed. 

New meshes for: aserai_noble_blade_5/Engraved Kaskara , aserai_blade_19/Iron Scimitar Blade.
XML edits for: aserai_noble_blade_6/Decorated Scimitar Blade, aserai_noble_blade_4/Decorated Scimitar Blade

