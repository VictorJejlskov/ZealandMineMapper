﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portofolie.Models.EquipmentStuff
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Self
    {
        public string href { get; set; }
    }

    public class Links
    {
        public Self self { get; set; }
    }

    public class Key
    {
        public string href { get; set; }
    }

    public class Realm
    {
        public Key key { get; set; }
        public string name { get; set; }
        public int id { get; set; }
        public string slug { get; set; }
    }

    public class Character
    {
        public Key key { get; set; }
        public string name { get; set; }
        public int id { get; set; }
        public Realm realm { get; set; }
    }

    public class Item
    {
        public Key key { get; set; }
        public int id { get; set; }
        public string name { get; set; }
    }

    public class SocketType
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Media
    {
        public Key key { get; set; }
        public int id { get; set; }
    }

    public class DisplayColor
    {
        public double r { get; set; }
        public double g { get; set; }
        public double b { get; set; }
        public double a { get; set; }
    }

    public class Socket
    {
        public SocketType socket_type { get; set; }
        public Item item { get; set; }
        public int context { get; set; }
        public string display_string { get; set; }
        public Media media { get; set; }
        public DisplayColor display_color { get; set; }
    }

    public class Slot
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Quality
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class ItemClass
    {
        public Key key { get; set; }
        public string name { get; set; }
        public int id { get; set; }
    }

    public class ItemSubclass
    {
        public Key key { get; set; }
        public string name { get; set; }
        public int id { get; set; }
    }

    public class InventoryType
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Binding
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Color
    {
        public double r { get; set; }
        public double g { get; set; }
        public double b { get; set; }
        public double a { get; set; }
    }

    public class Display
    {
        public string display_string { get; set; }
        public Color color { get; set; }
    }

    public class Armor
    {
        public int value { get; set; }
        public Display display { get; set; }
    }

    public class Type
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Stat
    {
        public Type type { get; set; }
        public int value { get; set; }
        public Display display { get; set; }
        public bool? is_equip_bonus { get; set; }
        public bool? is_negated { get; set; }
    }

    public class Spell2
    {
        public Key key { get; set; }
        public string name { get; set; }
        public int id { get; set; }
    }

    public class Spell
    {
        public Spell spell { get; set; }
        public string description { get; set; }
        public DisplayColor display_color { get; set; }
    }

    public class DisplayStrings
    {
        public string header { get; set; }
        public string gold { get; set; }
        public string silver { get; set; }
        public string copper { get; set; }
    }

    public class SellPrice
    {
        public int value { get; set; }
        public DisplayStrings display_strings { get; set; }
    }

    public class Level
    {
        public int value { get; set; }
        public string display_string { get; set; }
    }

    public class Requirements
    {
        public Level level { get; set; }
    }

    public class Transmog
    {
        public Item item { get; set; }
        public string display_string { get; set; }
        public int item_modified_appearance_id { get; set; }
    }

    public class Durability
    {
        public int value { get; set; }
        public string display_string { get; set; }
    }

    public class NameDescription
    {
        public string display_string { get; set; }
        public Color color { get; set; }
    }

    public class SourceItem
    {
        public Key key { get; set; }
        public string name { get; set; }
        public int id { get; set; }
    }

    public class EnchantmentSlot
    {
        public int id { get; set; }
        public string type { get; set; }
    }

    public class Enchantment
    {
        public string display_string { get; set; }
        public SourceItem source_item { get; set; }
        public int enchantment_id { get; set; }
        public EnchantmentSlot enchantment_slot { get; set; }
    }

    public class ModifiedCraftingStat
    {
        public int id { get; set; }
        public string type { get; set; }
        public string name { get; set; }
    }

    public class DamageClass
    {
        public string type { get; set; }
        public string name { get; set; }
    }

    public class Damage
    {
        public int min_value { get; set; }
        public int max_value { get; set; }
        public string display_string { get; set; }
        public DamageClass damage_class { get; set; }
    }

    public class AttackSpeed
    {
        public int value { get; set; }
        public string display_string { get; set; }
    }

    public class Dps
    {
        public double value { get; set; }
        public string display_string { get; set; }
    }

    public class Weapon
    {
        public Damage damage { get; set; }
        public AttackSpeed attack_speed { get; set; }
        public Dps dps { get; set; }
    }

    public class EquippedItem
    {
        public Item item { get; set; }
        public List<Socket> sockets { get; set; }
        public Slot slot { get; set; }
        public int quantity { get; set; }
        public int context { get; set; }
        public List<int> bonus_list { get; set; }
        public Quality quality { get; set; }
        public string name { get; set; }
        public int modified_appearance_id { get; set; }
        public Media media { get; set; }
        public ItemClass item_class { get; set; }
        public ItemSubclass item_subclass { get; set; }
        public InventoryType inventory_type { get; set; }
        public Binding binding { get; set; }
        public Armor armor { get; set; }
        public List<Stat> stats { get; set; }
        public List<Spell> spells { get; set; }
        public SellPrice sell_price { get; set; }
        public Requirements requirements { get; set; }
        public Level level { get; set; }
        public Transmog transmog { get; set; }
        public Durability durability { get; set; }
        public NameDescription name_description { get; set; }
        public bool? is_subclass_hidden { get; set; }
        public List<Enchantment> enchantments { get; set; }
        public string limit_category { get; set; }
        public string description { get; set; }
        public int? timewalker_level { get; set; }
        public string unique_equipped { get; set; }
        public List<ModifiedCraftingStat> modified_crafting_stat { get; set; }
        public Weapon weapon { get; set; }
    }

    public class EquipmentInfo
    {
        public Links _links { get; set; }
        public Character character { get; set; }
        public List<EquippedItem> equipped_items { get; set; }
    }


}
