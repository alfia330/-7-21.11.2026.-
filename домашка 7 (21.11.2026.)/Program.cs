//дом задание 8.2
using System;
using System.Collections.Generic;

class Song
{
    string name;
    string author;
    Song prev;

    public void SetName(string n) { name = n; }
    public void SetAuthor(string a) { author = a; }
    public void SetPrev(Song p) { prev = p; }

    public string Title()
    {
        return prev == null
            ? name + " (" + author + ")"
            : name + " (" + author + "), предыдущая: " + prev.Title();
    }

    public override bool Equals(object d)
    {
        Song other = d as Song;
        if (other == null) return false;
        return name == other.name && author == other.author;
    }

    public override int GetHashCode() => (name + author).GetHashCode();
}

class Program
{
    static void Main()
    {
        List<Song> songs = new List<Song>();

        Song s1 = new Song(); s1.SetName("Песня 1"); s1.SetAuthor("Автор 1"); songs.Add(s1);
        Song s2 = new Song(); s2.SetName("Песня 2"); s2.SetAuthor("Автор 2"); s2.SetPrev(s1); songs.Add(s2);
        Song s3 = new Song(); s3.SetName("Песня 3"); s3.SetAuthor("Автор 3"); s3.SetPrev(s2); songs.Add(s3);
        Song s4 = new Song(); s4.SetName("Песня 4"); s4.SetAuthor("Автор 4"); s4.SetPrev(s3); songs.Add(s4);

        foreach (Song song in songs)
            Console.WriteLine(song.Title());

        Console.WriteLine("Первая и вторая песни одинаковы: " + s1.Equals(s2));
        Console.WriteLine("Первая песня равна самой себе: " + s1.Equals(s1));
    }
}

