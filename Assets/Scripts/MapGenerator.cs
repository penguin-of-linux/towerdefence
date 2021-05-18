using Core.MapDto;
using Core.MapDto.Tiles;

namespace DefaultNamespace
{
    public static class MapGenerator
    {
        public static Map Generate()
        {
            var map = new Map(new Core.MapDto.Tile[18,13]);
            
            for(var x = 0; x < map.Width; x++)
            for (var y = 0; y < map.Height; y++)
                map[x, y] = new Ground(x, y);
            
            for(var x = 0; x < map.Width; x++)
            for (var y = 0; y < 2; y++)
            {
                map[x, y] = new Brick(x, y);
            }
            
            for(var x = 0; x < map.Width; x++)
            for (var y = 11; y < 13; y++)
            {
                map[x, y] = new Brick(x, y);
            }

            map[0, 2] = new Brick(0, 2);
            map[1, 2] = new Brick(1, 2);
            map[0, 3] = new Brick(0, 3);
            map[1, 3] = new Brick(1, 3);
            map[0, 4] = new Brick(0, 4);
            map[1, 4] = new Brick(1, 4);
            
            map[0, 8] = new Brick(0, 8);
            map[1, 8] = new Brick(1, 8);
            map[0, 9] = new Brick(0, 9);
            map[1, 9] = new Brick(1, 9);
            map[0, 10] = new Brick(0, 10);
            map[0, 10] = new Brick(1, 10);
            
            map[16, 2] = new Brick(16, 2);
            map[17, 2] = new Brick(17, 2);
            map[16, 3] = new Brick(16, 3);
            map[17, 3] = new Brick(17, 3);
            map[16, 4] = new Brick(16, 4);
            map[17, 4] = new Brick(17, 4);
            
            map[16, 8] = new Brick(16, 8);
            map[17, 8] = new Brick(17, 8);
            map[16, 9] = new Brick(16, 9);
            map[17, 9] = new Brick(17, 9);
            map[16, 10] = new Brick(16, 10);
            map[17, 10] = new Brick(17, 10);
            
            for(var x = 7; x < 10; x++)
            for (var y = 4; y < 10; y++)
                map[x, y] = new Brick(x, y);

            return map;
        }
    }
}