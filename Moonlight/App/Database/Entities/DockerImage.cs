﻿namespace Moonlight.App.Database.Entities;

public class DockerImage
{
    public int Id { get; set; }
    public bool Default { get; set; } = false;
    public string Name { get; set; } = "";
}