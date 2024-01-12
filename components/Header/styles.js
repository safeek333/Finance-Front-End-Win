import { StyleSheet } from 'react-native';

const styles = StyleSheet.create({
  container: {
    position: 'absolute',
    top: 50,
    zIndex: 100,
    flexDirection: 'row',
    justifyContent: 'space-between',
    width: '100%',
    paddingHorizontal: 20,
  },
  logo: {
    width: 250,
    height: 40,
    resizeMode: 'cover',
  },
  menu: {
    width: 25,
    height: 25,
    resizeMode: 'contain',
  }
});

export default styles;
