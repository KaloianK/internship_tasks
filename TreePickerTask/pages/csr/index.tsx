import Head from 'next/head'
import { GetStaticProps } from "next";
import { Card, CardMedia, CardContent, Typography, Grid, Link } from "@material-ui/core";
import { makeStyles } from '@material-ui/core/styles';

const useStyles = makeStyles({
    root: {
      maxWidth: 345,
      marginLeft: 30
    },
    media: {
      height: 360,
    },
    container: {
        spacing: 2,
        
        justify: "flex-start",
        alignItems: "flex-start"
    }
  });

  export type CSRProps = {
    /**
     * Character infos
     */
     characters: any
};

function CSR({ characters }: CSRProps) {
    const classes = useStyles();

    return (
        <div>
            <Head>
                <title>SSR Characters</title>
                <meta name="description" content="SSR Characters" />
                <link rel="icon" href="/modulus.png" />
            </Head>
            <h1>Client side rendering example - Main Characters</h1>
            <Grid container className={classes.container} direction="row">
            {characters.map((character: any, index: number) => (
                <Card key={index} className={classes.root}>
                    <CardMedia
                        className={classes.media}
                        image={character.image}
                        title="Contemplative Reptile"
                    />
                    <CardContent>
                        <Typography gutterBottom variant="h5" component="h2">
                            {character.name}
                        </Typography>
                        <Typography variant="body2" color="textSecondary" component="p">
                            Name is {character.name} a {character.gender} {character.species} from {<Link href='csr'>{character.origin.name}</Link>}.
                            Currently is located on {<Link href='/csr'>{character.location.name}</Link>} and status of subject is {character.status}.
                        </Typography>
                    </CardContent>
                </Card>
            ))
            }
            </Grid>
        </div>
    )
}

export const getStaticProps: GetStaticProps = async (context) => {
    const characterIds = [1, 2, 3, 4, 5, 66];
    const res = await fetch(`https://rickandmortyapi.com/api/character/${characterIds}`)
    const characters = await res.json();

    return {
        props: {
            characters
        },
        revalidate: 10
    }
}

export default CSR